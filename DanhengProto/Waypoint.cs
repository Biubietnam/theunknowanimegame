using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200141B RID: 5147
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Waypoint : IMessage<Waypoint>, IMessage, IEquatable<Waypoint>, IDeepCloneable<Waypoint>, IBufferMessage
	{
		// Token: 0x17004077 RID: 16503
		// (get) Token: 0x0600E59C RID: 58780 RVA: 0x00262750 File Offset: 0x00260950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Waypoint> Parser
		{
			get
			{
				return Waypoint._parser;
			}
		}

		// Token: 0x17004078 RID: 16504
		// (get) Token: 0x0600E59D RID: 58781 RVA: 0x00262757 File Offset: 0x00260957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WaypointReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004079 RID: 16505
		// (get) Token: 0x0600E59E RID: 58782 RVA: 0x00262769 File Offset: 0x00260969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Waypoint.Descriptor;
			}
		}

		// Token: 0x0600E59F RID: 58783 RVA: 0x00262770 File Offset: 0x00260970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Waypoint()
		{
		}

		// Token: 0x0600E5A0 RID: 58784 RVA: 0x00262778 File Offset: 0x00260978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Waypoint(Waypoint other) : this()
		{
			this.id_ = other.id_;
			this.isNew_ = other.isNew_;
			this.gNFDCOHGGFP_ = other.gNFDCOHGGFP_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E5A1 RID: 58785 RVA: 0x002627B5 File Offset: 0x002609B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Waypoint Clone()
		{
			return new Waypoint(this);
		}

		// Token: 0x1700407A RID: 16506
		// (get) Token: 0x0600E5A2 RID: 58786 RVA: 0x002627BD File Offset: 0x002609BD
		// (set) Token: 0x0600E5A3 RID: 58787 RVA: 0x002627C5 File Offset: 0x002609C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x1700407B RID: 16507
		// (get) Token: 0x0600E5A4 RID: 58788 RVA: 0x002627CE File Offset: 0x002609CE
		// (set) Token: 0x0600E5A5 RID: 58789 RVA: 0x002627D6 File Offset: 0x002609D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsNew
		{
			get
			{
				return this.isNew_;
			}
			set
			{
				this.isNew_ = value;
			}
		}

		// Token: 0x1700407C RID: 16508
		// (get) Token: 0x0600E5A6 RID: 58790 RVA: 0x002627DF File Offset: 0x002609DF
		// (set) Token: 0x0600E5A7 RID: 58791 RVA: 0x002627E7 File Offset: 0x002609E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GNFDCOHGGFP
		{
			get
			{
				return this.gNFDCOHGGFP_;
			}
			set
			{
				this.gNFDCOHGGFP_ = value;
			}
		}

		// Token: 0x0600E5A8 RID: 58792 RVA: 0x002627F0 File Offset: 0x002609F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Waypoint);
		}

		// Token: 0x0600E5A9 RID: 58793 RVA: 0x00262800 File Offset: 0x00260A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Waypoint other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.IsNew == other.IsNew && this.GNFDCOHGGFP == other.GNFDCOHGGFP && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E5AA RID: 58794 RVA: 0x0026285C File Offset: 0x00260A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.IsNew)
			{
				num ^= this.IsNew.GetHashCode();
			}
			if (this.GNFDCOHGGFP != 0U)
			{
				num ^= this.GNFDCOHGGFP.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E5AB RID: 58795 RVA: 0x002628CD File Offset: 0x00260ACD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E5AC RID: 58796 RVA: 0x002628D5 File Offset: 0x00260AD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E5AD RID: 58797 RVA: 0x002628E0 File Offset: 0x00260AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsNew)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsNew);
			}
			if (this.GNFDCOHGGFP != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.GNFDCOHGGFP);
			}
			if (this.Id != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E5AE RID: 58798 RVA: 0x00262954 File Offset: 0x00260B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this.IsNew)
			{
				num += 2;
			}
			if (this.GNFDCOHGGFP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GNFDCOHGGFP);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E5AF RID: 58799 RVA: 0x002629B8 File Offset: 0x00260BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Waypoint other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			if (other.IsNew)
			{
				this.IsNew = other.IsNew;
			}
			if (other.GNFDCOHGGFP != 0U)
			{
				this.GNFDCOHGGFP = other.GNFDCOHGGFP;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E5B0 RID: 58800 RVA: 0x00262A1C File Offset: 0x00260C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E5B1 RID: 58801 RVA: 0x00262A28 File Offset: 0x00260C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 40U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Id = input.ReadUInt32();
						}
					}
					else
					{
						this.GNFDCOHGGFP = input.ReadUInt32();
					}
				}
				else
				{
					this.IsNew = input.ReadBool();
				}
			}
		}

		// Token: 0x04005B2E RID: 23342
		private static readonly MessageParser<Waypoint> _parser = new MessageParser<Waypoint>(() => new Waypoint());

		// Token: 0x04005B2F RID: 23343
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B30 RID: 23344
		public const int IdFieldNumber = 14;

		// Token: 0x04005B31 RID: 23345
		private uint id_;

		// Token: 0x04005B32 RID: 23346
		public const int IsNewFieldNumber = 1;

		// Token: 0x04005B33 RID: 23347
		private bool isNew_;

		// Token: 0x04005B34 RID: 23348
		public const int GNFDCOHGGFPFieldNumber = 5;

		// Token: 0x04005B35 RID: 23349
		private uint gNFDCOHGGFP_;
	}
}
