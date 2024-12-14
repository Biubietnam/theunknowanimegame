using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D73 RID: 3443
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RaidTargetInfo : IMessage<RaidTargetInfo>, IMessage, IEquatable<RaidTargetInfo>, IDeepCloneable<RaidTargetInfo>, IBufferMessage
	{
		// Token: 0x17002B68 RID: 11112
		// (get) Token: 0x060099CF RID: 39375 RVA: 0x00199951 File Offset: 0x00197B51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RaidTargetInfo> Parser
		{
			get
			{
				return RaidTargetInfo._parser;
			}
		}

		// Token: 0x17002B69 RID: 11113
		// (get) Token: 0x060099D0 RID: 39376 RVA: 0x00199958 File Offset: 0x00197B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RaidTargetInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002B6A RID: 11114
		// (get) Token: 0x060099D1 RID: 39377 RVA: 0x0019996A File Offset: 0x00197B6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RaidTargetInfo.Descriptor;
			}
		}

		// Token: 0x060099D2 RID: 39378 RVA: 0x00199971 File Offset: 0x00197B71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RaidTargetInfo()
		{
		}

		// Token: 0x060099D3 RID: 39379 RVA: 0x00199979 File Offset: 0x00197B79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RaidTargetInfo(RaidTargetInfo other) : this()
		{
			this.hPDODHKHPGP_ = other.hPDODHKHPGP_;
			this.dIMBAOFNJGL_ = other.dIMBAOFNJGL_;
			this.gDAJKBOLPFH_ = other.gDAJKBOLPFH_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060099D4 RID: 39380 RVA: 0x001999B6 File Offset: 0x00197BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RaidTargetInfo Clone()
		{
			return new RaidTargetInfo(this);
		}

		// Token: 0x17002B6B RID: 11115
		// (get) Token: 0x060099D5 RID: 39381 RVA: 0x001999BE File Offset: 0x00197BBE
		// (set) Token: 0x060099D6 RID: 39382 RVA: 0x001999C6 File Offset: 0x00197BC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HPDODHKHPGP
		{
			get
			{
				return this.hPDODHKHPGP_;
			}
			set
			{
				this.hPDODHKHPGP_ = value;
			}
		}

		// Token: 0x17002B6C RID: 11116
		// (get) Token: 0x060099D7 RID: 39383 RVA: 0x001999CF File Offset: 0x00197BCF
		// (set) Token: 0x060099D8 RID: 39384 RVA: 0x001999D7 File Offset: 0x00197BD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DIMBAOFNJGL
		{
			get
			{
				return this.dIMBAOFNJGL_;
			}
			set
			{
				this.dIMBAOFNJGL_ = value;
			}
		}

		// Token: 0x17002B6D RID: 11117
		// (get) Token: 0x060099D9 RID: 39385 RVA: 0x001999E0 File Offset: 0x00197BE0
		// (set) Token: 0x060099DA RID: 39386 RVA: 0x001999E8 File Offset: 0x00197BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EFCHIKFLMFF GDAJKBOLPFH
		{
			get
			{
				return this.gDAJKBOLPFH_;
			}
			set
			{
				this.gDAJKBOLPFH_ = value;
			}
		}

		// Token: 0x060099DB RID: 39387 RVA: 0x001999F1 File Offset: 0x00197BF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RaidTargetInfo);
		}

		// Token: 0x060099DC RID: 39388 RVA: 0x00199A00 File Offset: 0x00197C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RaidTargetInfo other)
		{
			return other != null && (other == this || (this.HPDODHKHPGP == other.HPDODHKHPGP && this.DIMBAOFNJGL == other.DIMBAOFNJGL && this.GDAJKBOLPFH == other.GDAJKBOLPFH && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060099DD RID: 39389 RVA: 0x00199A5C File Offset: 0x00197C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HPDODHKHPGP != 0U)
			{
				num ^= this.HPDODHKHPGP.GetHashCode();
			}
			if (this.DIMBAOFNJGL != 0U)
			{
				num ^= this.DIMBAOFNJGL.GetHashCode();
			}
			if (this.GDAJKBOLPFH != EFCHIKFLMFF.RaidTargetStatusNone)
			{
				num ^= this.GDAJKBOLPFH.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060099DE RID: 39390 RVA: 0x00199AD3 File Offset: 0x00197CD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060099DF RID: 39391 RVA: 0x00199ADB File Offset: 0x00197CDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060099E0 RID: 39392 RVA: 0x00199AE4 File Offset: 0x00197CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HPDODHKHPGP != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.HPDODHKHPGP);
			}
			if (this.DIMBAOFNJGL != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.DIMBAOFNJGL);
			}
			if (this.GDAJKBOLPFH != EFCHIKFLMFF.RaidTargetStatusNone)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.GDAJKBOLPFH);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060099E1 RID: 39393 RVA: 0x00199B5C File Offset: 0x00197D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HPDODHKHPGP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HPDODHKHPGP);
			}
			if (this.DIMBAOFNJGL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DIMBAOFNJGL);
			}
			if (this.GDAJKBOLPFH != EFCHIKFLMFF.RaidTargetStatusNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.GDAJKBOLPFH);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060099E2 RID: 39394 RVA: 0x00199BCC File Offset: 0x00197DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RaidTargetInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HPDODHKHPGP != 0U)
			{
				this.HPDODHKHPGP = other.HPDODHKHPGP;
			}
			if (other.DIMBAOFNJGL != 0U)
			{
				this.DIMBAOFNJGL = other.DIMBAOFNJGL;
			}
			if (other.GDAJKBOLPFH != EFCHIKFLMFF.RaidTargetStatusNone)
			{
				this.GDAJKBOLPFH = other.GDAJKBOLPFH;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060099E3 RID: 39395 RVA: 0x00199C30 File Offset: 0x00197E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060099E4 RID: 39396 RVA: 0x00199C3C File Offset: 0x00197E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 56U)
					{
						if (num != 72U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.GDAJKBOLPFH = (EFCHIKFLMFF)input.ReadEnum();
						}
					}
					else
					{
						this.DIMBAOFNJGL = input.ReadUInt32();
					}
				}
				else
				{
					this.HPDODHKHPGP = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003BC0 RID: 15296
		private static readonly MessageParser<RaidTargetInfo> _parser = new MessageParser<RaidTargetInfo>(() => new RaidTargetInfo());

		// Token: 0x04003BC1 RID: 15297
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BC2 RID: 15298
		public const int HPDODHKHPGPFieldNumber = 5;

		// Token: 0x04003BC3 RID: 15299
		private uint hPDODHKHPGP_;

		// Token: 0x04003BC4 RID: 15300
		public const int DIMBAOFNJGLFieldNumber = 7;

		// Token: 0x04003BC5 RID: 15301
		private uint dIMBAOFNJGL_;

		// Token: 0x04003BC6 RID: 15302
		public const int GDAJKBOLPFHFieldNumber = 9;

		// Token: 0x04003BC7 RID: 15303
		private EFCHIKFLMFF gDAJKBOLPFH_;
	}
}
