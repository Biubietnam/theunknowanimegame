using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200137F RID: 4991
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TravelBrochureRemovePasterCsReq : IMessage<TravelBrochureRemovePasterCsReq>, IMessage, IEquatable<TravelBrochureRemovePasterCsReq>, IDeepCloneable<TravelBrochureRemovePasterCsReq>, IBufferMessage
	{
		// Token: 0x17003E86 RID: 16006
		// (get) Token: 0x0600DEA4 RID: 56996 RVA: 0x00250855 File Offset: 0x0024EA55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TravelBrochureRemovePasterCsReq> Parser
		{
			get
			{
				return TravelBrochureRemovePasterCsReq._parser;
			}
		}

		// Token: 0x17003E87 RID: 16007
		// (get) Token: 0x0600DEA5 RID: 56997 RVA: 0x0025085C File Offset: 0x0024EA5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TravelBrochureRemovePasterCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003E88 RID: 16008
		// (get) Token: 0x0600DEA6 RID: 56998 RVA: 0x0025086E File Offset: 0x0024EA6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TravelBrochureRemovePasterCsReq.Descriptor;
			}
		}

		// Token: 0x0600DEA7 RID: 56999 RVA: 0x00250875 File Offset: 0x0024EA75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureRemovePasterCsReq()
		{
		}

		// Token: 0x0600DEA8 RID: 57000 RVA: 0x0025087D File Offset: 0x0024EA7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureRemovePasterCsReq(TravelBrochureRemovePasterCsReq other) : this()
		{
			this.nMAKNJMFFJN_ = other.nMAKNJMFFJN_;
			this.uniqueId_ = other.uniqueId_;
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DEA9 RID: 57001 RVA: 0x002508BA File Offset: 0x0024EABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureRemovePasterCsReq Clone()
		{
			return new TravelBrochureRemovePasterCsReq(this);
		}

		// Token: 0x17003E89 RID: 16009
		// (get) Token: 0x0600DEAA RID: 57002 RVA: 0x002508C2 File Offset: 0x0024EAC2
		// (set) Token: 0x0600DEAB RID: 57003 RVA: 0x002508CA File Offset: 0x0024EACA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NMAKNJMFFJN
		{
			get
			{
				return this.nMAKNJMFFJN_;
			}
			set
			{
				this.nMAKNJMFFJN_ = value;
			}
		}

		// Token: 0x17003E8A RID: 16010
		// (get) Token: 0x0600DEAC RID: 57004 RVA: 0x002508D3 File Offset: 0x0024EAD3
		// (set) Token: 0x0600DEAD RID: 57005 RVA: 0x002508DB File Offset: 0x0024EADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong UniqueId
		{
			get
			{
				return this.uniqueId_;
			}
			set
			{
				this.uniqueId_ = value;
			}
		}

		// Token: 0x17003E8B RID: 16011
		// (get) Token: 0x0600DEAE RID: 57006 RVA: 0x002508E4 File Offset: 0x0024EAE4
		// (set) Token: 0x0600DEAF RID: 57007 RVA: 0x002508EC File Offset: 0x0024EAEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x0600DEB0 RID: 57008 RVA: 0x002508F5 File Offset: 0x0024EAF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TravelBrochureRemovePasterCsReq);
		}

		// Token: 0x0600DEB1 RID: 57009 RVA: 0x00250904 File Offset: 0x0024EB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TravelBrochureRemovePasterCsReq other)
		{
			return other != null && (other == this || (this.NMAKNJMFFJN == other.NMAKNJMFFJN && this.UniqueId == other.UniqueId && this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DEB2 RID: 57010 RVA: 0x00250960 File Offset: 0x0024EB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NMAKNJMFFJN != 0U)
			{
				num ^= this.NMAKNJMFFJN.GetHashCode();
			}
			if (this.UniqueId != 0UL)
			{
				num ^= this.UniqueId.GetHashCode();
			}
			if (this.ItemId != 0U)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DEB3 RID: 57011 RVA: 0x002509D1 File Offset: 0x0024EBD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DEB4 RID: 57012 RVA: 0x002509D9 File Offset: 0x0024EBD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DEB5 RID: 57013 RVA: 0x002509E4 File Offset: 0x0024EBE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.ItemId);
			}
			if (this.UniqueId != 0UL)
			{
				output.WriteRawTag(56);
				output.WriteUInt64(this.UniqueId);
			}
			if (this.NMAKNJMFFJN != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.NMAKNJMFFJN);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DEB6 RID: 57014 RVA: 0x00250A58 File Offset: 0x0024EC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NMAKNJMFFJN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NMAKNJMFFJN);
			}
			if (this.UniqueId != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.UniqueId);
			}
			if (this.ItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DEB7 RID: 57015 RVA: 0x00250AC8 File Offset: 0x0024ECC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TravelBrochureRemovePasterCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NMAKNJMFFJN != 0U)
			{
				this.NMAKNJMFFJN = other.NMAKNJMFFJN;
			}
			if (other.UniqueId != 0UL)
			{
				this.UniqueId = other.UniqueId;
			}
			if (other.ItemId != 0U)
			{
				this.ItemId = other.ItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DEB8 RID: 57016 RVA: 0x00250B2C File Offset: 0x0024ED2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DEB9 RID: 57017 RVA: 0x00250B38 File Offset: 0x0024ED38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 56U)
					{
						if (num != 64U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.NMAKNJMFFJN = input.ReadUInt32();
						}
					}
					else
					{
						this.UniqueId = input.ReadUInt64();
					}
				}
				else
				{
					this.ItemId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005882 RID: 22658
		private static readonly MessageParser<TravelBrochureRemovePasterCsReq> _parser = new MessageParser<TravelBrochureRemovePasterCsReq>(() => new TravelBrochureRemovePasterCsReq());

		// Token: 0x04005883 RID: 22659
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005884 RID: 22660
		public const int NMAKNJMFFJNFieldNumber = 8;

		// Token: 0x04005885 RID: 22661
		private uint nMAKNJMFFJN_;

		// Token: 0x04005886 RID: 22662
		public const int UniqueIdFieldNumber = 7;

		// Token: 0x04005887 RID: 22663
		private ulong uniqueId_;

		// Token: 0x04005888 RID: 22664
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04005889 RID: 22665
		private uint itemId_;
	}
}
