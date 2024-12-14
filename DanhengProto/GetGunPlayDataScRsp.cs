using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006E3 RID: 1763
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetGunPlayDataScRsp : IMessage<GetGunPlayDataScRsp>, IMessage, IEquatable<GetGunPlayDataScRsp>, IDeepCloneable<GetGunPlayDataScRsp>, IBufferMessage
	{
		// Token: 0x17001661 RID: 5729
		// (get) Token: 0x06004EDE RID: 20190 RVA: 0x000D53C5 File Offset: 0x000D35C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetGunPlayDataScRsp> Parser
		{
			get
			{
				return GetGunPlayDataScRsp._parser;
			}
		}

		// Token: 0x17001662 RID: 5730
		// (get) Token: 0x06004EDF RID: 20191 RVA: 0x000D53CC File Offset: 0x000D35CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetGunPlayDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001663 RID: 5731
		// (get) Token: 0x06004EE0 RID: 20192 RVA: 0x000D53DE File Offset: 0x000D35DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetGunPlayDataScRsp.Descriptor;
			}
		}

		// Token: 0x06004EE1 RID: 20193 RVA: 0x000D53E5 File Offset: 0x000D35E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetGunPlayDataScRsp()
		{
		}

		// Token: 0x06004EE2 RID: 20194 RVA: 0x000D53F8 File Offset: 0x000D35F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetGunPlayDataScRsp(GetGunPlayDataScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.mGCOGIIAMOB_ = other.mGCOGIIAMOB_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004EE3 RID: 20195 RVA: 0x000D542E File Offset: 0x000D362E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetGunPlayDataScRsp Clone()
		{
			return new GetGunPlayDataScRsp(this);
		}

		// Token: 0x17001664 RID: 5732
		// (get) Token: 0x06004EE4 RID: 20196 RVA: 0x000D5436 File Offset: 0x000D3636
		// (set) Token: 0x06004EE5 RID: 20197 RVA: 0x000D543E File Offset: 0x000D363E
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

		// Token: 0x17001665 RID: 5733
		// (get) Token: 0x06004EE6 RID: 20198 RVA: 0x000D5447 File Offset: 0x000D3647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NNEOOKDGDIK> MGCOGIIAMOB
		{
			get
			{
				return this.mGCOGIIAMOB_;
			}
		}

		// Token: 0x06004EE7 RID: 20199 RVA: 0x000D544F File Offset: 0x000D364F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetGunPlayDataScRsp);
		}

		// Token: 0x06004EE8 RID: 20200 RVA: 0x000D5460 File Offset: 0x000D3660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetGunPlayDataScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.mGCOGIIAMOB_.Equals(other.mGCOGIIAMOB_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004EE9 RID: 20201 RVA: 0x000D54B0 File Offset: 0x000D36B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.mGCOGIIAMOB_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004EEA RID: 20202 RVA: 0x000D54FD File Offset: 0x000D36FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004EEB RID: 20203 RVA: 0x000D5505 File Offset: 0x000D3705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004EEC RID: 20204 RVA: 0x000D5510 File Offset: 0x000D3710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			this.mGCOGIIAMOB_.WriteTo(ref output, GetGunPlayDataScRsp._repeated_mGCOGIIAMOB_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004EED RID: 20205 RVA: 0x000D5560 File Offset: 0x000D3760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.mGCOGIIAMOB_.CalculateSize(GetGunPlayDataScRsp._repeated_mGCOGIIAMOB_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004EEE RID: 20206 RVA: 0x000D55B4 File Offset: 0x000D37B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetGunPlayDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.mGCOGIIAMOB_.Add(other.mGCOGIIAMOB_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004EEF RID: 20207 RVA: 0x000D5601 File Offset: 0x000D3801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004EF0 RID: 20208 RVA: 0x000D560C File Offset: 0x000D380C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.mGCOGIIAMOB_.AddEntriesFrom(ref input, GetGunPlayDataScRsp._repeated_mGCOGIIAMOB_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001F1E RID: 7966
		private static readonly MessageParser<GetGunPlayDataScRsp> _parser = new MessageParser<GetGunPlayDataScRsp>(() => new GetGunPlayDataScRsp());

		// Token: 0x04001F1F RID: 7967
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F20 RID: 7968
		public const int RetcodeFieldNumber = 1;

		// Token: 0x04001F21 RID: 7969
		private uint retcode_;

		// Token: 0x04001F22 RID: 7970
		public const int MGCOGIIAMOBFieldNumber = 10;

		// Token: 0x04001F23 RID: 7971
		private static readonly FieldCodec<NNEOOKDGDIK> _repeated_mGCOGIIAMOB_codec = FieldCodec.ForMessage<NNEOOKDGDIK>(82U, NNEOOKDGDIK.Parser);

		// Token: 0x04001F24 RID: 7972
		private readonly RepeatedField<NNEOOKDGDIK> mGCOGIIAMOB_ = new RepeatedField<NNEOOKDGDIK>();
	}
}
