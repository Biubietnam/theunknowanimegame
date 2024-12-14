using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000783 RID: 1923
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetPunkLordMonsterDataScRsp : IMessage<GetPunkLordMonsterDataScRsp>, IMessage, IEquatable<GetPunkLordMonsterDataScRsp>, IDeepCloneable<GetPunkLordMonsterDataScRsp>, IBufferMessage
	{
		// Token: 0x17001850 RID: 6224
		// (get) Token: 0x060055EC RID: 21996 RVA: 0x000E6BAD File Offset: 0x000E4DAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetPunkLordMonsterDataScRsp> Parser
		{
			get
			{
				return GetPunkLordMonsterDataScRsp._parser;
			}
		}

		// Token: 0x17001851 RID: 6225
		// (get) Token: 0x060055ED RID: 21997 RVA: 0x000E6BB4 File Offset: 0x000E4DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetPunkLordMonsterDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001852 RID: 6226
		// (get) Token: 0x060055EE RID: 21998 RVA: 0x000E6BC6 File Offset: 0x000E4DC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetPunkLordMonsterDataScRsp.Descriptor;
			}
		}

		// Token: 0x060055EF RID: 21999 RVA: 0x000E6BCD File Offset: 0x000E4DCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPunkLordMonsterDataScRsp()
		{
		}

		// Token: 0x060055F0 RID: 22000 RVA: 0x000E6BE0 File Offset: 0x000E4DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPunkLordMonsterDataScRsp(GetPunkLordMonsterDataScRsp other) : this()
		{
			this.lMOHBMPBPAC_ = other.lMOHBMPBPAC_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060055F1 RID: 22001 RVA: 0x000E6C16 File Offset: 0x000E4E16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPunkLordMonsterDataScRsp Clone()
		{
			return new GetPunkLordMonsterDataScRsp(this);
		}

		// Token: 0x17001853 RID: 6227
		// (get) Token: 0x060055F2 RID: 22002 RVA: 0x000E6C1E File Offset: 0x000E4E1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MGLAPEBCMOO> LMOHBMPBPAC
		{
			get
			{
				return this.lMOHBMPBPAC_;
			}
		}

		// Token: 0x17001854 RID: 6228
		// (get) Token: 0x060055F3 RID: 22003 RVA: 0x000E6C26 File Offset: 0x000E4E26
		// (set) Token: 0x060055F4 RID: 22004 RVA: 0x000E6C2E File Offset: 0x000E4E2E
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

		// Token: 0x060055F5 RID: 22005 RVA: 0x000E6C37 File Offset: 0x000E4E37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetPunkLordMonsterDataScRsp);
		}

		// Token: 0x060055F6 RID: 22006 RVA: 0x000E6C48 File Offset: 0x000E4E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetPunkLordMonsterDataScRsp other)
		{
			return other != null && (other == this || (this.lMOHBMPBPAC_.Equals(other.lMOHBMPBPAC_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060055F7 RID: 22007 RVA: 0x000E6C98 File Offset: 0x000E4E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.lMOHBMPBPAC_.GetHashCode();
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

		// Token: 0x060055F8 RID: 22008 RVA: 0x000E6CE5 File Offset: 0x000E4EE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060055F9 RID: 22009 RVA: 0x000E6CED File Offset: 0x000E4EED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060055FA RID: 22010 RVA: 0x000E6CF8 File Offset: 0x000E4EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.lMOHBMPBPAC_.WriteTo(ref output, GetPunkLordMonsterDataScRsp._repeated_lMOHBMPBPAC_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060055FB RID: 22011 RVA: 0x000E6D48 File Offset: 0x000E4F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.lMOHBMPBPAC_.CalculateSize(GetPunkLordMonsterDataScRsp._repeated_lMOHBMPBPAC_codec);
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

		// Token: 0x060055FC RID: 22012 RVA: 0x000E6D9C File Offset: 0x000E4F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetPunkLordMonsterDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.lMOHBMPBPAC_.Add(other.lMOHBMPBPAC_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060055FD RID: 22013 RVA: 0x000E6DE9 File Offset: 0x000E4FE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060055FE RID: 22014 RVA: 0x000E6DF4 File Offset: 0x000E4FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 96U)
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
					this.lMOHBMPBPAC_.AddEntriesFrom(ref input, GetPunkLordMonsterDataScRsp._repeated_lMOHBMPBPAC_codec);
				}
			}
		}

		// Token: 0x040021AC RID: 8620
		private static readonly MessageParser<GetPunkLordMonsterDataScRsp> _parser = new MessageParser<GetPunkLordMonsterDataScRsp>(() => new GetPunkLordMonsterDataScRsp());

		// Token: 0x040021AD RID: 8621
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021AE RID: 8622
		public const int LMOHBMPBPACFieldNumber = 2;

		// Token: 0x040021AF RID: 8623
		private static readonly FieldCodec<MGLAPEBCMOO> _repeated_lMOHBMPBPAC_codec = FieldCodec.ForMessage<MGLAPEBCMOO>(18U, MGLAPEBCMOO.Parser);

		// Token: 0x040021B0 RID: 8624
		private readonly RepeatedField<MGLAPEBCMOO> lMOHBMPBPAC_ = new RepeatedField<MGLAPEBCMOO>();

		// Token: 0x040021B1 RID: 8625
		public const int RetcodeFieldNumber = 12;

		// Token: 0x040021B2 RID: 8626
		private uint retcode_;
	}
}
