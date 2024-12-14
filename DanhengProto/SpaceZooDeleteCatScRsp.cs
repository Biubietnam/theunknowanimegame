using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001165 RID: 4453
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpaceZooDeleteCatScRsp : IMessage<SpaceZooDeleteCatScRsp>, IMessage, IEquatable<SpaceZooDeleteCatScRsp>, IDeepCloneable<SpaceZooDeleteCatScRsp>, IBufferMessage
	{
		// Token: 0x1700380C RID: 14348
		// (get) Token: 0x0600C6AC RID: 50860 RVA: 0x002155F8 File Offset: 0x002137F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpaceZooDeleteCatScRsp> Parser
		{
			get
			{
				return SpaceZooDeleteCatScRsp._parser;
			}
		}

		// Token: 0x1700380D RID: 14349
		// (get) Token: 0x0600C6AD RID: 50861 RVA: 0x002155FF File Offset: 0x002137FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SpaceZooDeleteCatScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700380E RID: 14350
		// (get) Token: 0x0600C6AE RID: 50862 RVA: 0x00215611 File Offset: 0x00213811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpaceZooDeleteCatScRsp.Descriptor;
			}
		}

		// Token: 0x0600C6AF RID: 50863 RVA: 0x00215618 File Offset: 0x00213818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooDeleteCatScRsp()
		{
		}

		// Token: 0x0600C6B0 RID: 50864 RVA: 0x0021562B File Offset: 0x0021382B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooDeleteCatScRsp(SpaceZooDeleteCatScRsp other) : this()
		{
			this.hEMKBLMDPBP_ = other.hEMKBLMDPBP_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C6B1 RID: 50865 RVA: 0x00215661 File Offset: 0x00213861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooDeleteCatScRsp Clone()
		{
			return new SpaceZooDeleteCatScRsp(this);
		}

		// Token: 0x1700380F RID: 14351
		// (get) Token: 0x0600C6B2 RID: 50866 RVA: 0x00215669 File Offset: 0x00213869
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> HEMKBLMDPBP
		{
			get
			{
				return this.hEMKBLMDPBP_;
			}
		}

		// Token: 0x17003810 RID: 14352
		// (get) Token: 0x0600C6B3 RID: 50867 RVA: 0x00215671 File Offset: 0x00213871
		// (set) Token: 0x0600C6B4 RID: 50868 RVA: 0x00215679 File Offset: 0x00213879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x0600C6B5 RID: 50869 RVA: 0x00215682 File Offset: 0x00213882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpaceZooDeleteCatScRsp);
		}

		// Token: 0x0600C6B6 RID: 50870 RVA: 0x00215690 File Offset: 0x00213890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpaceZooDeleteCatScRsp other)
		{
			return other != null && (other == this || (this.hEMKBLMDPBP_.Equals(other.hEMKBLMDPBP_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C6B7 RID: 50871 RVA: 0x002156E0 File Offset: 0x002138E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.hEMKBLMDPBP_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C6B8 RID: 50872 RVA: 0x0021572D File Offset: 0x0021392D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C6B9 RID: 50873 RVA: 0x00215735 File Offset: 0x00213935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C6BA RID: 50874 RVA: 0x00215740 File Offset: 0x00213940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.hEMKBLMDPBP_.WriteTo(ref output, SpaceZooDeleteCatScRsp._repeated_hEMKBLMDPBP_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C6BB RID: 50875 RVA: 0x00215790 File Offset: 0x00213990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.hEMKBLMDPBP_.CalculateSize(SpaceZooDeleteCatScRsp._repeated_hEMKBLMDPBP_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C6BC RID: 50876 RVA: 0x002157E4 File Offset: 0x002139E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpaceZooDeleteCatScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.hEMKBLMDPBP_.Add(other.hEMKBLMDPBP_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C6BD RID: 50877 RVA: 0x00215831 File Offset: 0x00213A31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C6BE RID: 50878 RVA: 0x0021583C File Offset: 0x00213A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U && num != 34U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.hEMKBLMDPBP_.AddEntriesFrom(ref input, SpaceZooDeleteCatScRsp._repeated_hEMKBLMDPBP_codec);
				}
			}
		}

		// Token: 0x0400504C RID: 20556
		private static readonly MessageParser<SpaceZooDeleteCatScRsp> _parser = new MessageParser<SpaceZooDeleteCatScRsp>(() => new SpaceZooDeleteCatScRsp());

		// Token: 0x0400504D RID: 20557
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400504E RID: 20558
		public const int HEMKBLMDPBPFieldNumber = 4;

		// Token: 0x0400504F RID: 20559
		private static readonly FieldCodec<uint> _repeated_hEMKBLMDPBP_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x04005050 RID: 20560
		private readonly RepeatedField<uint> hEMKBLMDPBP_ = new RepeatedField<uint>();

		// Token: 0x04005051 RID: 20561
		public const int RetcodeFieldNumber = 13;

		// Token: 0x04005052 RID: 20562
		private uint retcode_;
	}
}
