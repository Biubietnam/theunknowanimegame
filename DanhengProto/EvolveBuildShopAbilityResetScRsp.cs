using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004BF RID: 1215
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EvolveBuildShopAbilityResetScRsp : IMessage<EvolveBuildShopAbilityResetScRsp>, IMessage, IEquatable<EvolveBuildShopAbilityResetScRsp>, IDeepCloneable<EvolveBuildShopAbilityResetScRsp>, IBufferMessage
	{
		// Token: 0x17000F80 RID: 3968
		// (get) Token: 0x0600364C RID: 13900 RVA: 0x0009547B File Offset: 0x0009367B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EvolveBuildShopAbilityResetScRsp> Parser
		{
			get
			{
				return EvolveBuildShopAbilityResetScRsp._parser;
			}
		}

		// Token: 0x17000F81 RID: 3969
		// (get) Token: 0x0600364D RID: 13901 RVA: 0x00095482 File Offset: 0x00093682
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EvolveBuildShopAbilityResetScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000F82 RID: 3970
		// (get) Token: 0x0600364E RID: 13902 RVA: 0x00095494 File Offset: 0x00093694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EvolveBuildShopAbilityResetScRsp.Descriptor;
			}
		}

		// Token: 0x0600364F RID: 13903 RVA: 0x0009549B File Offset: 0x0009369B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildShopAbilityResetScRsp()
		{
		}

		// Token: 0x06003650 RID: 13904 RVA: 0x000954B0 File Offset: 0x000936B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildShopAbilityResetScRsp(EvolveBuildShopAbilityResetScRsp other) : this()
		{
			this.hLGLFNABFOP_ = other.hLGLFNABFOP_.Clone();
			this.retcode_ = other.retcode_;
			this.itemValue_ = other.itemValue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003651 RID: 13905 RVA: 0x000954FD File Offset: 0x000936FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildShopAbilityResetScRsp Clone()
		{
			return new EvolveBuildShopAbilityResetScRsp(this);
		}

		// Token: 0x17000F83 RID: 3971
		// (get) Token: 0x06003652 RID: 13906 RVA: 0x00095505 File Offset: 0x00093705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NHCDHNDCJMI> HLGLFNABFOP
		{
			get
			{
				return this.hLGLFNABFOP_;
			}
		}

		// Token: 0x17000F84 RID: 3972
		// (get) Token: 0x06003653 RID: 13907 RVA: 0x0009550D File Offset: 0x0009370D
		// (set) Token: 0x06003654 RID: 13908 RVA: 0x00095515 File Offset: 0x00093715
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

		// Token: 0x17000F85 RID: 3973
		// (get) Token: 0x06003655 RID: 13909 RVA: 0x0009551E File Offset: 0x0009371E
		// (set) Token: 0x06003656 RID: 13910 RVA: 0x00095526 File Offset: 0x00093726
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ItemValue
		{
			get
			{
				return this.itemValue_;
			}
			set
			{
				this.itemValue_ = value;
			}
		}

		// Token: 0x06003657 RID: 13911 RVA: 0x0009552F File Offset: 0x0009372F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EvolveBuildShopAbilityResetScRsp);
		}

		// Token: 0x06003658 RID: 13912 RVA: 0x00095540 File Offset: 0x00093740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EvolveBuildShopAbilityResetScRsp other)
		{
			return other != null && (other == this || (this.hLGLFNABFOP_.Equals(other.hLGLFNABFOP_) && this.Retcode == other.Retcode && this.ItemValue == other.ItemValue && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003659 RID: 13913 RVA: 0x000955A0 File Offset: 0x000937A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.hLGLFNABFOP_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.ItemValue != 0U)
			{
				num ^= this.ItemValue.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600365A RID: 13914 RVA: 0x00095606 File Offset: 0x00093806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600365B RID: 13915 RVA: 0x0009560E File Offset: 0x0009380E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600365C RID: 13916 RVA: 0x00095618 File Offset: 0x00093818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			this.hLGLFNABFOP_.WriteTo(ref output, EvolveBuildShopAbilityResetScRsp._repeated_hLGLFNABFOP_codec);
			if (this.ItemValue != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.ItemValue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600365D RID: 13917 RVA: 0x00095684 File Offset: 0x00093884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.hLGLFNABFOP_.CalculateSize(EvolveBuildShopAbilityResetScRsp._repeated_hLGLFNABFOP_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.ItemValue != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemValue);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600365E RID: 13918 RVA: 0x000956F0 File Offset: 0x000938F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EvolveBuildShopAbilityResetScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.hLGLFNABFOP_.Add(other.hLGLFNABFOP_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.ItemValue != 0U)
			{
				this.ItemValue = other.ItemValue;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600365F RID: 13919 RVA: 0x00095751 File Offset: 0x00093951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003660 RID: 13920 RVA: 0x0009575C File Offset: 0x0009395C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 34U)
					{
						if (num != 40U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ItemValue = input.ReadUInt32();
						}
					}
					else
					{
						this.hLGLFNABFOP_.AddEntriesFrom(ref input, EvolveBuildShopAbilityResetScRsp._repeated_hLGLFNABFOP_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001597 RID: 5527
		private static readonly MessageParser<EvolveBuildShopAbilityResetScRsp> _parser = new MessageParser<EvolveBuildShopAbilityResetScRsp>(() => new EvolveBuildShopAbilityResetScRsp());

		// Token: 0x04001598 RID: 5528
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001599 RID: 5529
		public const int HLGLFNABFOPFieldNumber = 4;

		// Token: 0x0400159A RID: 5530
		private static readonly FieldCodec<NHCDHNDCJMI> _repeated_hLGLFNABFOP_codec = FieldCodec.ForMessage<NHCDHNDCJMI>(34U, NHCDHNDCJMI.Parser);

		// Token: 0x0400159B RID: 5531
		private readonly RepeatedField<NHCDHNDCJMI> hLGLFNABFOP_ = new RepeatedField<NHCDHNDCJMI>();

		// Token: 0x0400159C RID: 5532
		public const int RetcodeFieldNumber = 2;

		// Token: 0x0400159D RID: 5533
		private uint retcode_;

		// Token: 0x0400159E RID: 5534
		public const int ItemValueFieldNumber = 5;

		// Token: 0x0400159F RID: 5535
		private uint itemValue_;
	}
}
