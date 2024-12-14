using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008AD RID: 2221
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HEFAKEFDMBL : IMessage<HEFAKEFDMBL>, IMessage, IEquatable<HEFAKEFDMBL>, IDeepCloneable<HEFAKEFDMBL>, IBufferMessage
	{
		// Token: 0x17001BD8 RID: 7128
		// (get) Token: 0x060062E7 RID: 25319 RVA: 0x00108BAD File Offset: 0x00106DAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HEFAKEFDMBL> Parser
		{
			get
			{
				return HEFAKEFDMBL._parser;
			}
		}

		// Token: 0x17001BD9 RID: 7129
		// (get) Token: 0x060062E8 RID: 25320 RVA: 0x00108BB4 File Offset: 0x00106DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HEFAKEFDMBLReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001BDA RID: 7130
		// (get) Token: 0x060062E9 RID: 25321 RVA: 0x00108BC6 File Offset: 0x00106DC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HEFAKEFDMBL.Descriptor;
			}
		}

		// Token: 0x060062EA RID: 25322 RVA: 0x00108BCD File Offset: 0x00106DCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HEFAKEFDMBL()
		{
		}

		// Token: 0x060062EB RID: 25323 RVA: 0x00108BD8 File Offset: 0x00106DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HEFAKEFDMBL(HEFAKEFDMBL other) : this()
		{
			this.eKOMHBLHFGC_ = other.eKOMHBLHFGC_;
			this.dICPGJDDBGM_ = other.dICPGJDDBGM_;
			this.gHOBHDCLBHF_ = other.gHOBHDCLBHF_;
			this.cLJLGHCPIIF_ = other.cLJLGHCPIIF_;
			this.groupId_ = other.groupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060062EC RID: 25324 RVA: 0x00108C38 File Offset: 0x00106E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HEFAKEFDMBL Clone()
		{
			return new HEFAKEFDMBL(this);
		}

		// Token: 0x17001BDB RID: 7131
		// (get) Token: 0x060062ED RID: 25325 RVA: 0x00108C40 File Offset: 0x00106E40
		// (set) Token: 0x060062EE RID: 25326 RVA: 0x00108C48 File Offset: 0x00106E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EKOMHBLHFGC
		{
			get
			{
				return this.eKOMHBLHFGC_;
			}
			set
			{
				this.eKOMHBLHFGC_ = value;
			}
		}

		// Token: 0x17001BDC RID: 7132
		// (get) Token: 0x060062EF RID: 25327 RVA: 0x00108C51 File Offset: 0x00106E51
		// (set) Token: 0x060062F0 RID: 25328 RVA: 0x00108C59 File Offset: 0x00106E59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool DICPGJDDBGM
		{
			get
			{
				return this.dICPGJDDBGM_;
			}
			set
			{
				this.dICPGJDDBGM_ = value;
			}
		}

		// Token: 0x17001BDD RID: 7133
		// (get) Token: 0x060062F1 RID: 25329 RVA: 0x00108C62 File Offset: 0x00106E62
		// (set) Token: 0x060062F2 RID: 25330 RVA: 0x00108C6A File Offset: 0x00106E6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GHOBHDCLBHF
		{
			get
			{
				return this.gHOBHDCLBHF_;
			}
			set
			{
				this.gHOBHDCLBHF_ = value;
			}
		}

		// Token: 0x17001BDE RID: 7134
		// (get) Token: 0x060062F3 RID: 25331 RVA: 0x00108C73 File Offset: 0x00106E73
		// (set) Token: 0x060062F4 RID: 25332 RVA: 0x00108C7B File Offset: 0x00106E7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CLJLGHCPIIF
		{
			get
			{
				return this.cLJLGHCPIIF_;
			}
			set
			{
				this.cLJLGHCPIIF_ = value;
			}
		}

		// Token: 0x17001BDF RID: 7135
		// (get) Token: 0x060062F5 RID: 25333 RVA: 0x00108C84 File Offset: 0x00106E84
		// (set) Token: 0x060062F6 RID: 25334 RVA: 0x00108C8C File Offset: 0x00106E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x060062F7 RID: 25335 RVA: 0x00108C95 File Offset: 0x00106E95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HEFAKEFDMBL);
		}

		// Token: 0x060062F8 RID: 25336 RVA: 0x00108CA4 File Offset: 0x00106EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HEFAKEFDMBL other)
		{
			return other != null && (other == this || (this.EKOMHBLHFGC == other.EKOMHBLHFGC && this.DICPGJDDBGM == other.DICPGJDDBGM && this.GHOBHDCLBHF == other.GHOBHDCLBHF && this.CLJLGHCPIIF == other.CLJLGHCPIIF && this.GroupId == other.GroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060062F9 RID: 25337 RVA: 0x00108D20 File Offset: 0x00106F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EKOMHBLHFGC != 0U)
			{
				num ^= this.EKOMHBLHFGC.GetHashCode();
			}
			if (this.DICPGJDDBGM)
			{
				num ^= this.DICPGJDDBGM.GetHashCode();
			}
			if (this.GHOBHDCLBHF != 0U)
			{
				num ^= this.GHOBHDCLBHF.GetHashCode();
			}
			if (this.CLJLGHCPIIF != 0U)
			{
				num ^= this.CLJLGHCPIIF.GetHashCode();
			}
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060062FA RID: 25338 RVA: 0x00108DC3 File Offset: 0x00106FC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060062FB RID: 25339 RVA: 0x00108DCB File Offset: 0x00106FCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060062FC RID: 25340 RVA: 0x00108DD4 File Offset: 0x00106FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CLJLGHCPIIF != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.CLJLGHCPIIF);
			}
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.GroupId);
			}
			if (this.EKOMHBLHFGC != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.EKOMHBLHFGC);
			}
			if (this.GHOBHDCLBHF != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.GHOBHDCLBHF);
			}
			if (this.DICPGJDDBGM)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.DICPGJDDBGM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060062FD RID: 25341 RVA: 0x00108E84 File Offset: 0x00107084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EKOMHBLHFGC != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EKOMHBLHFGC);
			}
			if (this.DICPGJDDBGM)
			{
				num += 2;
			}
			if (this.GHOBHDCLBHF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GHOBHDCLBHF);
			}
			if (this.CLJLGHCPIIF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CLJLGHCPIIF);
			}
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060062FE RID: 25342 RVA: 0x00108F18 File Offset: 0x00107118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HEFAKEFDMBL other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EKOMHBLHFGC != 0U)
			{
				this.EKOMHBLHFGC = other.EKOMHBLHFGC;
			}
			if (other.DICPGJDDBGM)
			{
				this.DICPGJDDBGM = other.DICPGJDDBGM;
			}
			if (other.GHOBHDCLBHF != 0U)
			{
				this.GHOBHDCLBHF = other.GHOBHDCLBHF;
			}
			if (other.CLJLGHCPIIF != 0U)
			{
				this.CLJLGHCPIIF = other.CLJLGHCPIIF;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060062FF RID: 25343 RVA: 0x00108FA4 File Offset: 0x001071A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006300 RID: 25344 RVA: 0x00108FB0 File Offset: 0x001071B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 24U)
				{
					if (num == 16U)
					{
						this.CLJLGHCPIIF = input.ReadUInt32();
						continue;
					}
					if (num == 24U)
					{
						this.GroupId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.EKOMHBLHFGC = input.ReadUInt32();
						continue;
					}
					if (num == 48U)
					{
						this.GHOBHDCLBHF = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.DICPGJDDBGM = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002612 RID: 9746
		private static readonly MessageParser<HEFAKEFDMBL> _parser = new MessageParser<HEFAKEFDMBL>(() => new HEFAKEFDMBL());

		// Token: 0x04002613 RID: 9747
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002614 RID: 9748
		public const int EKOMHBLHFGCFieldNumber = 4;

		// Token: 0x04002615 RID: 9749
		private uint eKOMHBLHFGC_;

		// Token: 0x04002616 RID: 9750
		public const int DICPGJDDBGMFieldNumber = 13;

		// Token: 0x04002617 RID: 9751
		private bool dICPGJDDBGM_;

		// Token: 0x04002618 RID: 9752
		public const int GHOBHDCLBHFFieldNumber = 6;

		// Token: 0x04002619 RID: 9753
		private uint gHOBHDCLBHF_;

		// Token: 0x0400261A RID: 9754
		public const int CLJLGHCPIIFFieldNumber = 2;

		// Token: 0x0400261B RID: 9755
		private uint cLJLGHCPIIF_;

		// Token: 0x0400261C RID: 9756
		public const int GroupIdFieldNumber = 3;

		// Token: 0x0400261D RID: 9757
		private uint groupId_;
	}
}
