using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003CB RID: 971
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DPCAMGELHBP : IMessage<DPCAMGELHBP>, IMessage, IEquatable<DPCAMGELHBP>, IDeepCloneable<DPCAMGELHBP>, IBufferMessage
	{
		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x06002B3C RID: 11068 RVA: 0x000788B9 File Offset: 0x00076AB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DPCAMGELHBP> Parser
		{
			get
			{
				return DPCAMGELHBP._parser;
			}
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x06002B3D RID: 11069 RVA: 0x000788C0 File Offset: 0x00076AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DPCAMGELHBPReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x06002B3E RID: 11070 RVA: 0x000788D2 File Offset: 0x00076AD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DPCAMGELHBP.Descriptor;
			}
		}

		// Token: 0x06002B3F RID: 11071 RVA: 0x000788D9 File Offset: 0x00076AD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DPCAMGELHBP()
		{
		}

		// Token: 0x06002B40 RID: 11072 RVA: 0x000788F7 File Offset: 0x00076AF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DPCAMGELHBP(DPCAMGELHBP other) : this()
		{
			this.hINIBDNFAON_ = other.hINIBDNFAON_.Clone();
			this.lFHCJIBBMHB_ = other.lFHCJIBBMHB_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002B41 RID: 11073 RVA: 0x00078932 File Offset: 0x00076B32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DPCAMGELHBP Clone()
		{
			return new DPCAMGELHBP(this);
		}

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x06002B42 RID: 11074 RVA: 0x0007893A File Offset: 0x00076B3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HAKAOKNJJDL> HINIBDNFAON
		{
			get
			{
				return this.hINIBDNFAON_;
			}
		}

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x06002B43 RID: 11075 RVA: 0x00078942 File Offset: 0x00076B42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> LFHCJIBBMHB
		{
			get
			{
				return this.lFHCJIBBMHB_;
			}
		}

		// Token: 0x06002B44 RID: 11076 RVA: 0x0007894A File Offset: 0x00076B4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DPCAMGELHBP);
		}

		// Token: 0x06002B45 RID: 11077 RVA: 0x00078958 File Offset: 0x00076B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DPCAMGELHBP other)
		{
			return other != null && (other == this || (this.hINIBDNFAON_.Equals(other.hINIBDNFAON_) && this.lFHCJIBBMHB_.Equals(other.lFHCJIBBMHB_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002B46 RID: 11078 RVA: 0x000789AC File Offset: 0x00076BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.hINIBDNFAON_.GetHashCode();
			num ^= this.lFHCJIBBMHB_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002B47 RID: 11079 RVA: 0x000789EE File Offset: 0x00076BEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002B48 RID: 11080 RVA: 0x000789F6 File Offset: 0x00076BF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002B49 RID: 11081 RVA: 0x000789FF File Offset: 0x00076BFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.lFHCJIBBMHB_.WriteTo(ref output, DPCAMGELHBP._repeated_lFHCJIBBMHB_codec);
			this.hINIBDNFAON_.WriteTo(ref output, DPCAMGELHBP._repeated_hINIBDNFAON_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002B4A RID: 11082 RVA: 0x00078A38 File Offset: 0x00076C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.hINIBDNFAON_.CalculateSize(DPCAMGELHBP._repeated_hINIBDNFAON_codec);
			num += this.lFHCJIBBMHB_.CalculateSize(DPCAMGELHBP._repeated_lFHCJIBBMHB_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002B4B RID: 11083 RVA: 0x00078A84 File Offset: 0x00076C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DPCAMGELHBP other)
		{
			if (other == null)
			{
				return;
			}
			this.hINIBDNFAON_.Add(other.hINIBDNFAON_);
			this.lFHCJIBBMHB_.Add(other.lFHCJIBBMHB_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002B4C RID: 11084 RVA: 0x00078AC3 File Offset: 0x00076CC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002B4D RID: 11085 RVA: 0x00078ACC File Offset: 0x00076CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U && num != 42U)
				{
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.hINIBDNFAON_.AddEntriesFrom(ref input, DPCAMGELHBP._repeated_hINIBDNFAON_codec);
					}
				}
				else
				{
					this.lFHCJIBBMHB_.AddEntriesFrom(ref input, DPCAMGELHBP._repeated_lFHCJIBBMHB_codec);
				}
			}
		}

		// Token: 0x0400118E RID: 4494
		private static readonly MessageParser<DPCAMGELHBP> _parser = new MessageParser<DPCAMGELHBP>(() => new DPCAMGELHBP());

		// Token: 0x0400118F RID: 4495
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001190 RID: 4496
		public const int HINIBDNFAONFieldNumber = 9;

		// Token: 0x04001191 RID: 4497
		private static readonly FieldCodec<HAKAOKNJJDL> _repeated_hINIBDNFAON_codec = FieldCodec.ForMessage<HAKAOKNJJDL>(74U, HAKAOKNJJDL.Parser);

		// Token: 0x04001192 RID: 4498
		private readonly RepeatedField<HAKAOKNJJDL> hINIBDNFAON_ = new RepeatedField<HAKAOKNJJDL>();

		// Token: 0x04001193 RID: 4499
		public const int LFHCJIBBMHBFieldNumber = 5;

		// Token: 0x04001194 RID: 4500
		private static readonly FieldCodec<uint> _repeated_lFHCJIBBMHB_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x04001195 RID: 4501
		private readonly RepeatedField<uint> lFHCJIBBMHB_ = new RepeatedField<uint>();
	}
}
