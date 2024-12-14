using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200125F RID: 4703
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncAcceptedPamMissionNotify : IMessage<SyncAcceptedPamMissionNotify>, IMessage, IEquatable<SyncAcceptedPamMissionNotify>, IDeepCloneable<SyncAcceptedPamMissionNotify>, IBufferMessage
	{
		// Token: 0x17003B1F RID: 15135
		// (get) Token: 0x0600D1F9 RID: 53753 RVA: 0x00231675 File Offset: 0x0022F875
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncAcceptedPamMissionNotify> Parser
		{
			get
			{
				return SyncAcceptedPamMissionNotify._parser;
			}
		}

		// Token: 0x17003B20 RID: 15136
		// (get) Token: 0x0600D1FA RID: 53754 RVA: 0x0023167C File Offset: 0x0022F87C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncAcceptedPamMissionNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003B21 RID: 15137
		// (get) Token: 0x0600D1FB RID: 53755 RVA: 0x0023168E File Offset: 0x0022F88E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncAcceptedPamMissionNotify.Descriptor;
			}
		}

		// Token: 0x0600D1FC RID: 53756 RVA: 0x00231695 File Offset: 0x0022F895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncAcceptedPamMissionNotify()
		{
		}

		// Token: 0x0600D1FD RID: 53757 RVA: 0x0023169D File Offset: 0x0022F89D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncAcceptedPamMissionNotify(SyncAcceptedPamMissionNotify other) : this()
		{
			this.mainMissionId_ = other.mainMissionId_;
			this.gBEIGBCGGNI_ = other.gBEIGBCGGNI_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D1FE RID: 53758 RVA: 0x002316CE File Offset: 0x0022F8CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncAcceptedPamMissionNotify Clone()
		{
			return new SyncAcceptedPamMissionNotify(this);
		}

		// Token: 0x17003B22 RID: 15138
		// (get) Token: 0x0600D1FF RID: 53759 RVA: 0x002316D6 File Offset: 0x0022F8D6
		// (set) Token: 0x0600D200 RID: 53760 RVA: 0x002316DE File Offset: 0x0022F8DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MainMissionId
		{
			get
			{
				return this.mainMissionId_;
			}
			set
			{
				this.mainMissionId_ = value;
			}
		}

		// Token: 0x17003B23 RID: 15139
		// (get) Token: 0x0600D201 RID: 53761 RVA: 0x002316E7 File Offset: 0x0022F8E7
		// (set) Token: 0x0600D202 RID: 53762 RVA: 0x002316EF File Offset: 0x0022F8EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong GBEIGBCGGNI
		{
			get
			{
				return this.gBEIGBCGGNI_;
			}
			set
			{
				this.gBEIGBCGGNI_ = value;
			}
		}

		// Token: 0x0600D203 RID: 53763 RVA: 0x002316F8 File Offset: 0x0022F8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncAcceptedPamMissionNotify);
		}

		// Token: 0x0600D204 RID: 53764 RVA: 0x00231706 File Offset: 0x0022F906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncAcceptedPamMissionNotify other)
		{
			return other != null && (other == this || (this.MainMissionId == other.MainMissionId && this.GBEIGBCGGNI == other.GBEIGBCGGNI && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D205 RID: 53765 RVA: 0x00231744 File Offset: 0x0022F944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MainMissionId != 0U)
			{
				num ^= this.MainMissionId.GetHashCode();
			}
			if (this.GBEIGBCGGNI != 0UL)
			{
				num ^= this.GBEIGBCGGNI.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D206 RID: 53766 RVA: 0x0023179C File Offset: 0x0022F99C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D207 RID: 53767 RVA: 0x002317A4 File Offset: 0x0022F9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D208 RID: 53768 RVA: 0x002317B0 File Offset: 0x0022F9B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GBEIGBCGGNI != 0UL)
			{
				output.WriteRawTag(96);
				output.WriteUInt64(this.GBEIGBCGGNI);
			}
			if (this.MainMissionId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.MainMissionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D209 RID: 53769 RVA: 0x0023180C File Offset: 0x0022FA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MainMissionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MainMissionId);
			}
			if (this.GBEIGBCGGNI != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.GBEIGBCGGNI);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D20A RID: 53770 RVA: 0x00231864 File Offset: 0x0022FA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncAcceptedPamMissionNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MainMissionId != 0U)
			{
				this.MainMissionId = other.MainMissionId;
			}
			if (other.GBEIGBCGGNI != 0UL)
			{
				this.GBEIGBCGGNI = other.GBEIGBCGGNI;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D20B RID: 53771 RVA: 0x002318B4 File Offset: 0x0022FAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D20C RID: 53772 RVA: 0x002318C0 File Offset: 0x0022FAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MainMissionId = input.ReadUInt32();
					}
				}
				else
				{
					this.GBEIGBCGGNI = input.ReadUInt64();
				}
			}
		}

		// Token: 0x04005436 RID: 21558
		private static readonly MessageParser<SyncAcceptedPamMissionNotify> _parser = new MessageParser<SyncAcceptedPamMissionNotify>(() => new SyncAcceptedPamMissionNotify());

		// Token: 0x04005437 RID: 21559
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005438 RID: 21560
		public const int MainMissionIdFieldNumber = 13;

		// Token: 0x04005439 RID: 21561
		private uint mainMissionId_;

		// Token: 0x0400543A RID: 21562
		public const int GBEIGBCGGNIFieldNumber = 12;

		// Token: 0x0400543B RID: 21563
		private ulong gBEIGBCGGNI_;
	}
}
