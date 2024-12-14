using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D09 RID: 3337
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PromoteAvatarCsReq : IMessage<PromoteAvatarCsReq>, IMessage, IEquatable<PromoteAvatarCsReq>, IDeepCloneable<PromoteAvatarCsReq>, IBufferMessage
	{
		// Token: 0x17002A04 RID: 10756
		// (get) Token: 0x06009504 RID: 38148 RVA: 0x0018C30D File Offset: 0x0018A50D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PromoteAvatarCsReq> Parser
		{
			get
			{
				return PromoteAvatarCsReq._parser;
			}
		}

		// Token: 0x17002A05 RID: 10757
		// (get) Token: 0x06009505 RID: 38149 RVA: 0x0018C314 File Offset: 0x0018A514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PromoteAvatarCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002A06 RID: 10758
		// (get) Token: 0x06009506 RID: 38150 RVA: 0x0018C326 File Offset: 0x0018A526
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PromoteAvatarCsReq.Descriptor;
			}
		}

		// Token: 0x06009507 RID: 38151 RVA: 0x0018C32D File Offset: 0x0018A52D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PromoteAvatarCsReq()
		{
		}

		// Token: 0x06009508 RID: 38152 RVA: 0x0018C340 File Offset: 0x0018A540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PromoteAvatarCsReq(PromoteAvatarCsReq other) : this()
		{
			this.itemList_ = other.itemList_.Clone();
			this.baseAvatarId_ = other.baseAvatarId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009509 RID: 38153 RVA: 0x0018C376 File Offset: 0x0018A576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PromoteAvatarCsReq Clone()
		{
			return new PromoteAvatarCsReq(this);
		}

		// Token: 0x17002A07 RID: 10759
		// (get) Token: 0x0600950A RID: 38154 RVA: 0x0018C37E File Offset: 0x0018A57E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ItemCost> ItemList
		{
			get
			{
				return this.itemList_;
			}
		}

		// Token: 0x17002A08 RID: 10760
		// (get) Token: 0x0600950B RID: 38155 RVA: 0x0018C386 File Offset: 0x0018A586
		// (set) Token: 0x0600950C RID: 38156 RVA: 0x0018C38E File Offset: 0x0018A58E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BaseAvatarId
		{
			get
			{
				return this.baseAvatarId_;
			}
			set
			{
				this.baseAvatarId_ = value;
			}
		}

		// Token: 0x0600950D RID: 38157 RVA: 0x0018C397 File Offset: 0x0018A597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PromoteAvatarCsReq);
		}

		// Token: 0x0600950E RID: 38158 RVA: 0x0018C3A8 File Offset: 0x0018A5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PromoteAvatarCsReq other)
		{
			return other != null && (other == this || (this.itemList_.Equals(other.itemList_) && this.BaseAvatarId == other.BaseAvatarId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600950F RID: 38159 RVA: 0x0018C3F8 File Offset: 0x0018A5F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.itemList_.GetHashCode();
			if (this.BaseAvatarId != 0U)
			{
				num ^= this.BaseAvatarId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009510 RID: 38160 RVA: 0x0018C445 File Offset: 0x0018A645
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009511 RID: 38161 RVA: 0x0018C44D File Offset: 0x0018A64D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009512 RID: 38162 RVA: 0x0018C458 File Offset: 0x0018A658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemList_.WriteTo(ref output, PromoteAvatarCsReq._repeated_itemList_codec);
			if (this.BaseAvatarId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.BaseAvatarId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009513 RID: 38163 RVA: 0x0018C4A8 File Offset: 0x0018A6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.itemList_.CalculateSize(PromoteAvatarCsReq._repeated_itemList_codec);
			if (this.BaseAvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BaseAvatarId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009514 RID: 38164 RVA: 0x0018C4FC File Offset: 0x0018A6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PromoteAvatarCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.itemList_.Add(other.itemList_);
			if (other.BaseAvatarId != 0U)
			{
				this.BaseAvatarId = other.BaseAvatarId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009515 RID: 38165 RVA: 0x0018C549 File Offset: 0x0018A749
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009516 RID: 38166 RVA: 0x0018C554 File Offset: 0x0018A754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BaseAvatarId = input.ReadUInt32();
					}
				}
				else
				{
					this.itemList_.AddEntriesFrom(ref input, PromoteAvatarCsReq._repeated_itemList_codec);
				}
			}
		}

		// Token: 0x040039C7 RID: 14791
		private static readonly MessageParser<PromoteAvatarCsReq> _parser = new MessageParser<PromoteAvatarCsReq>(() => new PromoteAvatarCsReq());

		// Token: 0x040039C8 RID: 14792
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039C9 RID: 14793
		public const int ItemListFieldNumber = 2;

		// Token: 0x040039CA RID: 14794
		private static readonly FieldCodec<ItemCost> _repeated_itemList_codec = FieldCodec.ForMessage<ItemCost>(18U, ItemCost.Parser);

		// Token: 0x040039CB RID: 14795
		private readonly RepeatedField<ItemCost> itemList_ = new RepeatedField<ItemCost>();

		// Token: 0x040039CC RID: 14796
		public const int BaseAvatarIdFieldNumber = 13;

		// Token: 0x040039CD RID: 14797
		private uint baseAvatarId_;
	}
}
