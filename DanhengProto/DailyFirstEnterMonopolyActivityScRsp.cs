using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200034F RID: 847
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DailyFirstEnterMonopolyActivityScRsp : IMessage<DailyFirstEnterMonopolyActivityScRsp>, IMessage, IEquatable<DailyFirstEnterMonopolyActivityScRsp>, IDeepCloneable<DailyFirstEnterMonopolyActivityScRsp>, IBufferMessage
	{
		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x060025CC RID: 9676 RVA: 0x0006A7AB File Offset: 0x000689AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DailyFirstEnterMonopolyActivityScRsp> Parser
		{
			get
			{
				return DailyFirstEnterMonopolyActivityScRsp._parser;
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x060025CD RID: 9677 RVA: 0x0006A7B2 File Offset: 0x000689B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DailyFirstEnterMonopolyActivityScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x060025CE RID: 9678 RVA: 0x0006A7C4 File Offset: 0x000689C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyFirstEnterMonopolyActivityScRsp.Descriptor;
			}
		}

		// Token: 0x060025CF RID: 9679 RVA: 0x0006A7CB File Offset: 0x000689CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyFirstEnterMonopolyActivityScRsp()
		{
		}

		// Token: 0x060025D0 RID: 9680 RVA: 0x0006A7D4 File Offset: 0x000689D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyFirstEnterMonopolyActivityScRsp(DailyFirstEnterMonopolyActivityScRsp other) : this()
		{
			this.pCOEFKDDBOE_ = ((other.pCOEFKDDBOE_ != null) ? other.pCOEFKDDBOE_.Clone() : null);
			this.hOOEOJELHID_ = other.hOOEOJELHID_;
			this.aABJAEIBGGM_ = other.aABJAEIBGGM_;
			this.retcode_ = other.retcode_;
			this.bPAHDPMBCCJ_ = other.bPAHDPMBCCJ_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060025D1 RID: 9681 RVA: 0x0006A844 File Offset: 0x00068A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyFirstEnterMonopolyActivityScRsp Clone()
		{
			return new DailyFirstEnterMonopolyActivityScRsp(this);
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x060025D2 RID: 9682 RVA: 0x0006A84C File Offset: 0x00068A4C
		// (set) Token: 0x060025D3 RID: 9683 RVA: 0x0006A854 File Offset: 0x00068A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OEEFPPBEAOF PCOEFKDDBOE
		{
			get
			{
				return this.pCOEFKDDBOE_;
			}
			set
			{
				this.pCOEFKDDBOE_ = value;
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x060025D4 RID: 9684 RVA: 0x0006A85D File Offset: 0x00068A5D
		// (set) Token: 0x060025D5 RID: 9685 RVA: 0x0006A865 File Offset: 0x00068A65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HOOEOJELHID
		{
			get
			{
				return this.hOOEOJELHID_;
			}
			set
			{
				this.hOOEOJELHID_ = value;
			}
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x060025D6 RID: 9686 RVA: 0x0006A86E File Offset: 0x00068A6E
		// (set) Token: 0x060025D7 RID: 9687 RVA: 0x0006A876 File Offset: 0x00068A76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long AABJAEIBGGM
		{
			get
			{
				return this.aABJAEIBGGM_;
			}
			set
			{
				this.aABJAEIBGGM_ = value;
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x060025D8 RID: 9688 RVA: 0x0006A87F File Offset: 0x00068A7F
		// (set) Token: 0x060025D9 RID: 9689 RVA: 0x0006A887 File Offset: 0x00068A87
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

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x060025DA RID: 9690 RVA: 0x0006A890 File Offset: 0x00068A90
		// (set) Token: 0x060025DB RID: 9691 RVA: 0x0006A898 File Offset: 0x00068A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool BPAHDPMBCCJ
		{
			get
			{
				return this.bPAHDPMBCCJ_;
			}
			set
			{
				this.bPAHDPMBCCJ_ = value;
			}
		}

		// Token: 0x060025DC RID: 9692 RVA: 0x0006A8A1 File Offset: 0x00068AA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyFirstEnterMonopolyActivityScRsp);
		}

		// Token: 0x060025DD RID: 9693 RVA: 0x0006A8B0 File Offset: 0x00068AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyFirstEnterMonopolyActivityScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.PCOEFKDDBOE, other.PCOEFKDDBOE) && this.HOOEOJELHID == other.HOOEOJELHID && this.AABJAEIBGGM == other.AABJAEIBGGM && this.Retcode == other.Retcode && this.BPAHDPMBCCJ == other.BPAHDPMBCCJ && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060025DE RID: 9694 RVA: 0x0006A930 File Offset: 0x00068B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.pCOEFKDDBOE_ != null)
			{
				num ^= this.PCOEFKDDBOE.GetHashCode();
			}
			if (this.HOOEOJELHID != 0U)
			{
				num ^= this.HOOEOJELHID.GetHashCode();
			}
			if (this.AABJAEIBGGM != 0L)
			{
				num ^= this.AABJAEIBGGM.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.BPAHDPMBCCJ)
			{
				num ^= this.BPAHDPMBCCJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060025DF RID: 9695 RVA: 0x0006A9D0 File Offset: 0x00068BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060025E0 RID: 9696 RVA: 0x0006A9D8 File Offset: 0x00068BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060025E1 RID: 9697 RVA: 0x0006A9E4 File Offset: 0x00068BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AABJAEIBGGM != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.AABJAEIBGGM);
			}
			if (this.HOOEOJELHID != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.HOOEOJELHID);
			}
			if (this.pCOEFKDDBOE_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.PCOEFKDDBOE);
			}
			if (this.BPAHDPMBCCJ)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.BPAHDPMBCCJ);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060025E2 RID: 9698 RVA: 0x0006AA94 File Offset: 0x00068C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.pCOEFKDDBOE_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PCOEFKDDBOE);
			}
			if (this.HOOEOJELHID != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HOOEOJELHID);
			}
			if (this.AABJAEIBGGM != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.AABJAEIBGGM);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.BPAHDPMBCCJ)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060025E3 RID: 9699 RVA: 0x0006AB28 File Offset: 0x00068D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DailyFirstEnterMonopolyActivityScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.pCOEFKDDBOE_ != null)
			{
				if (this.pCOEFKDDBOE_ == null)
				{
					this.PCOEFKDDBOE = new OEEFPPBEAOF();
				}
				this.PCOEFKDDBOE.MergeFrom(other.PCOEFKDDBOE);
			}
			if (other.HOOEOJELHID != 0U)
			{
				this.HOOEOJELHID = other.HOOEOJELHID;
			}
			if (other.AABJAEIBGGM != 0L)
			{
				this.AABJAEIBGGM = other.AABJAEIBGGM;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.BPAHDPMBCCJ)
			{
				this.BPAHDPMBCCJ = other.BPAHDPMBCCJ;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060025E4 RID: 9700 RVA: 0x0006ABCC File Offset: 0x00068DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060025E5 RID: 9701 RVA: 0x0006ABD8 File Offset: 0x00068DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
				{
					if (num == 24U)
					{
						this.AABJAEIBGGM = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.HOOEOJELHID = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 42U)
					{
						if (this.pCOEFKDDBOE_ == null)
						{
							this.PCOEFKDDBOE = new OEEFPPBEAOF();
						}
						input.ReadMessage(this.PCOEFKDDBOE);
						continue;
					}
					if (num == 88U)
					{
						this.BPAHDPMBCCJ = input.ReadBool();
						continue;
					}
					if (num == 120U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000F62 RID: 3938
		private static readonly MessageParser<DailyFirstEnterMonopolyActivityScRsp> _parser = new MessageParser<DailyFirstEnterMonopolyActivityScRsp>(() => new DailyFirstEnterMonopolyActivityScRsp());

		// Token: 0x04000F63 RID: 3939
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F64 RID: 3940
		public const int PCOEFKDDBOEFieldNumber = 5;

		// Token: 0x04000F65 RID: 3941
		private OEEFPPBEAOF pCOEFKDDBOE_;

		// Token: 0x04000F66 RID: 3942
		public const int HOOEOJELHIDFieldNumber = 4;

		// Token: 0x04000F67 RID: 3943
		private uint hOOEOJELHID_;

		// Token: 0x04000F68 RID: 3944
		public const int AABJAEIBGGMFieldNumber = 3;

		// Token: 0x04000F69 RID: 3945
		private long aABJAEIBGGM_;

		// Token: 0x04000F6A RID: 3946
		public const int RetcodeFieldNumber = 15;

		// Token: 0x04000F6B RID: 3947
		private uint retcode_;

		// Token: 0x04000F6C RID: 3948
		public const int BPAHDPMBCCJFieldNumber = 11;

		// Token: 0x04000F6D RID: 3949
		private bool bPAHDPMBCCJ_;
	}
}
