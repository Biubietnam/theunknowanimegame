using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000097 RID: 151
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AlleyShipUsedCountScNotify : IMessage<AlleyShipUsedCountScNotify>, IMessage, IEquatable<AlleyShipUsedCountScNotify>, IDeepCloneable<AlleyShipUsedCountScNotify>, IBufferMessage
	{
		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x000125D8 File Offset: 0x000107D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AlleyShipUsedCountScNotify> Parser
		{
			get
			{
				return AlleyShipUsedCountScNotify._parser;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x000125DF File Offset: 0x000107DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AlleyShipUsedCountScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x000125F1 File Offset: 0x000107F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AlleyShipUsedCountScNotify.Descriptor;
			}
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x000125F8 File Offset: 0x000107F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyShipUsedCountScNotify()
		{
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x0001260B File Offset: 0x0001080B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyShipUsedCountScNotify(AlleyShipUsedCountScNotify other) : this()
		{
			this.nLDEAJOMBIO_ = other.nLDEAJOMBIO_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00012635 File Offset: 0x00010835
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyShipUsedCountScNotify Clone()
		{
			return new AlleyShipUsedCountScNotify(this);
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x0001263D File Offset: 0x0001083D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, uint> NLDEAJOMBIO
		{
			get
			{
				return this.nLDEAJOMBIO_;
			}
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00012645 File Offset: 0x00010845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AlleyShipUsedCountScNotify);
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00012653 File Offset: 0x00010853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AlleyShipUsedCountScNotify other)
		{
			return other != null && (other == this || (this.NLDEAJOMBIO.Equals(other.NLDEAJOMBIO) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00012688 File Offset: 0x00010888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.NLDEAJOMBIO.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x000126BC File Offset: 0x000108BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x000126C4 File Offset: 0x000108C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x000126CD File Offset: 0x000108CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.nLDEAJOMBIO_.WriteTo(ref output, AlleyShipUsedCountScNotify._map_nLDEAJOMBIO_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x000126F4 File Offset: 0x000108F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.nLDEAJOMBIO_.CalculateSize(AlleyShipUsedCountScNotify._map_nLDEAJOMBIO_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x0001272D File Offset: 0x0001092D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AlleyShipUsedCountScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.nLDEAJOMBIO_.MergeFrom(other.nLDEAJOMBIO_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x0001275B File Offset: 0x0001095B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00012764 File Offset: 0x00010964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.nLDEAJOMBIO_.AddEntriesFrom(ref input, AlleyShipUsedCountScNotify._map_nLDEAJOMBIO_codec);
				}
			}
		}

		// Token: 0x04000265 RID: 613
		private static readonly MessageParser<AlleyShipUsedCountScNotify> _parser = new MessageParser<AlleyShipUsedCountScNotify>(() => new AlleyShipUsedCountScNotify());

		// Token: 0x04000266 RID: 614
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000267 RID: 615
		public const int NLDEAJOMBIOFieldNumber = 13;

		// Token: 0x04000268 RID: 616
		private static readonly MapField<uint, uint>.Codec _map_nLDEAJOMBIO_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForUInt32(16U, 0U), 106U);

		// Token: 0x04000269 RID: 617
		private readonly MapField<uint, uint> nLDEAJOMBIO_ = new MapField<uint, uint>();
	}
}
