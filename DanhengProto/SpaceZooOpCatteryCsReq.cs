using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200116F RID: 4463
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpaceZooOpCatteryCsReq : IMessage<SpaceZooOpCatteryCsReq>, IMessage, IEquatable<SpaceZooOpCatteryCsReq>, IDeepCloneable<SpaceZooOpCatteryCsReq>, IBufferMessage
	{
		// Token: 0x1700382B RID: 14379
		// (get) Token: 0x0600C71F RID: 50975 RVA: 0x00216739 File Offset: 0x00214939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpaceZooOpCatteryCsReq> Parser
		{
			get
			{
				return SpaceZooOpCatteryCsReq._parser;
			}
		}

		// Token: 0x1700382C RID: 14380
		// (get) Token: 0x0600C720 RID: 50976 RVA: 0x00216740 File Offset: 0x00214940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SpaceZooOpCatteryCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700382D RID: 14381
		// (get) Token: 0x0600C721 RID: 50977 RVA: 0x00216752 File Offset: 0x00214952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpaceZooOpCatteryCsReq.Descriptor;
			}
		}

		// Token: 0x0600C722 RID: 50978 RVA: 0x00216759 File Offset: 0x00214959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooOpCatteryCsReq()
		{
		}

		// Token: 0x0600C723 RID: 50979 RVA: 0x00216761 File Offset: 0x00214961
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooOpCatteryCsReq(SpaceZooOpCatteryCsReq other) : this()
		{
			this.opType_ = other.opType_;
			this.mAPEBDOJJEJ_ = other.mAPEBDOJJEJ_;
			this.pELBBKHJONM_ = other.pELBBKHJONM_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C724 RID: 50980 RVA: 0x0021679E File Offset: 0x0021499E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooOpCatteryCsReq Clone()
		{
			return new SpaceZooOpCatteryCsReq(this);
		}

		// Token: 0x1700382E RID: 14382
		// (get) Token: 0x0600C725 RID: 50981 RVA: 0x002167A6 File Offset: 0x002149A6
		// (set) Token: 0x0600C726 RID: 50982 RVA: 0x002167AE File Offset: 0x002149AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OpType
		{
			get
			{
				return this.opType_;
			}
			set
			{
				this.opType_ = value;
			}
		}

		// Token: 0x1700382F RID: 14383
		// (get) Token: 0x0600C727 RID: 50983 RVA: 0x002167B7 File Offset: 0x002149B7
		// (set) Token: 0x0600C728 RID: 50984 RVA: 0x002167BF File Offset: 0x002149BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MAPEBDOJJEJ
		{
			get
			{
				return this.mAPEBDOJJEJ_;
			}
			set
			{
				this.mAPEBDOJJEJ_ = value;
			}
		}

		// Token: 0x17003830 RID: 14384
		// (get) Token: 0x0600C729 RID: 50985 RVA: 0x002167C8 File Offset: 0x002149C8
		// (set) Token: 0x0600C72A RID: 50986 RVA: 0x002167D0 File Offset: 0x002149D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PELBBKHJONM
		{
			get
			{
				return this.pELBBKHJONM_;
			}
			set
			{
				this.pELBBKHJONM_ = value;
			}
		}

		// Token: 0x0600C72B RID: 50987 RVA: 0x002167D9 File Offset: 0x002149D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpaceZooOpCatteryCsReq);
		}

		// Token: 0x0600C72C RID: 50988 RVA: 0x002167E8 File Offset: 0x002149E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpaceZooOpCatteryCsReq other)
		{
			return other != null && (other == this || (this.OpType == other.OpType && this.MAPEBDOJJEJ == other.MAPEBDOJJEJ && this.PELBBKHJONM == other.PELBBKHJONM && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C72D RID: 50989 RVA: 0x00216844 File Offset: 0x00214A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OpType != 0U)
			{
				num ^= this.OpType.GetHashCode();
			}
			if (this.MAPEBDOJJEJ != 0U)
			{
				num ^= this.MAPEBDOJJEJ.GetHashCode();
			}
			if (this.PELBBKHJONM != 0U)
			{
				num ^= this.PELBBKHJONM.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C72E RID: 50990 RVA: 0x002168B5 File Offset: 0x00214AB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C72F RID: 50991 RVA: 0x002168BD File Offset: 0x00214ABD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C730 RID: 50992 RVA: 0x002168C8 File Offset: 0x00214AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MAPEBDOJJEJ != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.MAPEBDOJJEJ);
			}
			if (this.OpType != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.OpType);
			}
			if (this.PELBBKHJONM != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.PELBBKHJONM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C731 RID: 50993 RVA: 0x0021693C File Offset: 0x00214B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OpType != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OpType);
			}
			if (this.MAPEBDOJJEJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MAPEBDOJJEJ);
			}
			if (this.PELBBKHJONM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PELBBKHJONM);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C732 RID: 50994 RVA: 0x002169AC File Offset: 0x00214BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpaceZooOpCatteryCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OpType != 0U)
			{
				this.OpType = other.OpType;
			}
			if (other.MAPEBDOJJEJ != 0U)
			{
				this.MAPEBDOJJEJ = other.MAPEBDOJJEJ;
			}
			if (other.PELBBKHJONM != 0U)
			{
				this.PELBBKHJONM = other.PELBBKHJONM;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C733 RID: 50995 RVA: 0x00216A10 File Offset: 0x00214C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C734 RID: 50996 RVA: 0x00216A1C File Offset: 0x00214C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 96U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.PELBBKHJONM = input.ReadUInt32();
						}
					}
					else
					{
						this.OpType = input.ReadUInt32();
					}
				}
				else
				{
					this.MAPEBDOJJEJ = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005073 RID: 20595
		private static readonly MessageParser<SpaceZooOpCatteryCsReq> _parser = new MessageParser<SpaceZooOpCatteryCsReq>(() => new SpaceZooOpCatteryCsReq());

		// Token: 0x04005074 RID: 20596
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005075 RID: 20597
		public const int OpTypeFieldNumber = 12;

		// Token: 0x04005076 RID: 20598
		private uint opType_;

		// Token: 0x04005077 RID: 20599
		public const int MAPEBDOJJEJFieldNumber = 1;

		// Token: 0x04005078 RID: 20600
		private uint mAPEBDOJJEJ_;

		// Token: 0x04005079 RID: 20601
		public const int PELBBKHJONMFieldNumber = 15;

		// Token: 0x0400507A RID: 20602
		private uint pELBBKHJONM_;
	}
}
