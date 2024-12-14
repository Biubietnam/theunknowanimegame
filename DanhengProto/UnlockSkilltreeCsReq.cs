using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013C7 RID: 5063
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UnlockSkilltreeCsReq : IMessage<UnlockSkilltreeCsReq>, IMessage, IEquatable<UnlockSkilltreeCsReq>, IDeepCloneable<UnlockSkilltreeCsReq>, IBufferMessage
	{
		// Token: 0x17003F63 RID: 16227
		// (get) Token: 0x0600E1AF RID: 57775 RVA: 0x00258779 File Offset: 0x00256979
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UnlockSkilltreeCsReq> Parser
		{
			get
			{
				return UnlockSkilltreeCsReq._parser;
			}
		}

		// Token: 0x17003F64 RID: 16228
		// (get) Token: 0x0600E1B0 RID: 57776 RVA: 0x00258780 File Offset: 0x00256980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UnlockSkilltreeCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003F65 RID: 16229
		// (get) Token: 0x0600E1B1 RID: 57777 RVA: 0x00258792 File Offset: 0x00256992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockSkilltreeCsReq.Descriptor;
			}
		}

		// Token: 0x0600E1B2 RID: 57778 RVA: 0x00258799 File Offset: 0x00256999
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockSkilltreeCsReq()
		{
		}

		// Token: 0x0600E1B3 RID: 57779 RVA: 0x002587AC File Offset: 0x002569AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockSkilltreeCsReq(UnlockSkilltreeCsReq other) : this()
		{
			this.pointId_ = other.pointId_;
			this.itemList_ = other.itemList_.Clone();
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E1B4 RID: 57780 RVA: 0x002587F9 File Offset: 0x002569F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockSkilltreeCsReq Clone()
		{
			return new UnlockSkilltreeCsReq(this);
		}

		// Token: 0x17003F66 RID: 16230
		// (get) Token: 0x0600E1B5 RID: 57781 RVA: 0x00258801 File Offset: 0x00256A01
		// (set) Token: 0x0600E1B6 RID: 57782 RVA: 0x00258809 File Offset: 0x00256A09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PointId
		{
			get
			{
				return this.pointId_;
			}
			set
			{
				this.pointId_ = value;
			}
		}

		// Token: 0x17003F67 RID: 16231
		// (get) Token: 0x0600E1B7 RID: 57783 RVA: 0x00258812 File Offset: 0x00256A12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ItemCost> ItemList
		{
			get
			{
				return this.itemList_;
			}
		}

		// Token: 0x17003F68 RID: 16232
		// (get) Token: 0x0600E1B8 RID: 57784 RVA: 0x0025881A File Offset: 0x00256A1A
		// (set) Token: 0x0600E1B9 RID: 57785 RVA: 0x00258822 File Offset: 0x00256A22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x0600E1BA RID: 57786 RVA: 0x0025882B File Offset: 0x00256A2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockSkilltreeCsReq);
		}

		// Token: 0x0600E1BB RID: 57787 RVA: 0x0025883C File Offset: 0x00256A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockSkilltreeCsReq other)
		{
			return other != null && (other == this || (this.PointId == other.PointId && this.itemList_.Equals(other.itemList_) && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E1BC RID: 57788 RVA: 0x0025889C File Offset: 0x00256A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PointId != 0U)
			{
				num ^= this.PointId.GetHashCode();
			}
			num ^= this.itemList_.GetHashCode();
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E1BD RID: 57789 RVA: 0x00258902 File Offset: 0x00256B02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E1BE RID: 57790 RVA: 0x0025890A File Offset: 0x00256B0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E1BF RID: 57791 RVA: 0x00258914 File Offset: 0x00256B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PointId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.PointId);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Level);
			}
			this.itemList_.WriteTo(ref output, UnlockSkilltreeCsReq._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E1C0 RID: 57792 RVA: 0x00258980 File Offset: 0x00256B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PointId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PointId);
			}
			num += this.itemList_.CalculateSize(UnlockSkilltreeCsReq._repeated_itemList_codec);
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E1C1 RID: 57793 RVA: 0x002589EC File Offset: 0x00256BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlockSkilltreeCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PointId != 0U)
			{
				this.PointId = other.PointId;
			}
			this.itemList_.Add(other.itemList_);
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E1C2 RID: 57794 RVA: 0x00258A4D File Offset: 0x00256C4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E1C3 RID: 57795 RVA: 0x00258A58 File Offset: 0x00256C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 72U)
					{
						if (num != 98U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.itemList_.AddEntriesFrom(ref input, UnlockSkilltreeCsReq._repeated_itemList_codec);
						}
					}
					else
					{
						this.Level = input.ReadUInt32();
					}
				}
				else
				{
					this.PointId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040059CF RID: 22991
		private static readonly MessageParser<UnlockSkilltreeCsReq> _parser = new MessageParser<UnlockSkilltreeCsReq>(() => new UnlockSkilltreeCsReq());

		// Token: 0x040059D0 RID: 22992
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059D1 RID: 22993
		public const int PointIdFieldNumber = 3;

		// Token: 0x040059D2 RID: 22994
		private uint pointId_;

		// Token: 0x040059D3 RID: 22995
		public const int ItemListFieldNumber = 12;

		// Token: 0x040059D4 RID: 22996
		private static readonly FieldCodec<ItemCost> _repeated_itemList_codec = FieldCodec.ForMessage<ItemCost>(98U, ItemCost.Parser);

		// Token: 0x040059D5 RID: 22997
		private readonly RepeatedField<ItemCost> itemList_ = new RepeatedField<ItemCost>();

		// Token: 0x040059D6 RID: 22998
		public const int LevelFieldNumber = 9;

		// Token: 0x040059D7 RID: 22999
		private uint level_;
	}
}
