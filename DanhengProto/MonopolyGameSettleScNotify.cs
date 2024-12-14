using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B3B RID: 2875
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyGameSettleScNotify : IMessage<MonopolyGameSettleScNotify>, IMessage, IEquatable<MonopolyGameSettleScNotify>, IDeepCloneable<MonopolyGameSettleScNotify>, IBufferMessage
	{
		// Token: 0x170023AF RID: 9135
		// (get) Token: 0x06007F3E RID: 32574 RVA: 0x001502BF File Offset: 0x0014E4BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyGameSettleScNotify> Parser
		{
			get
			{
				return MonopolyGameSettleScNotify._parser;
			}
		}

		// Token: 0x170023B0 RID: 9136
		// (get) Token: 0x06007F3F RID: 32575 RVA: 0x001502C6 File Offset: 0x0014E4C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyGameSettleScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170023B1 RID: 9137
		// (get) Token: 0x06007F40 RID: 32576 RVA: 0x001502D8 File Offset: 0x0014E4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyGameSettleScNotify.Descriptor;
			}
		}

		// Token: 0x06007F41 RID: 32577 RVA: 0x001502DF File Offset: 0x0014E4DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGameSettleScNotify()
		{
		}

		// Token: 0x06007F42 RID: 32578 RVA: 0x001502E8 File Offset: 0x0014E4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGameSettleScNotify(MonopolyGameSettleScNotify other) : this()
		{
			this.bEDINILDMEB_ = ((other.bEDINILDMEB_ != null) ? other.bEDINILDMEB_.Clone() : null);
			this.hMBJIFIGLFI_ = ((other.hMBJIFIGLFI_ != null) ? other.hMBJIFIGLFI_.Clone() : null);
			this.itemList_ = ((other.itemList_ != null) ? other.itemList_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007F43 RID: 32579 RVA: 0x00150360 File Offset: 0x0014E560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGameSettleScNotify Clone()
		{
			return new MonopolyGameSettleScNotify(this);
		}

		// Token: 0x170023B2 RID: 9138
		// (get) Token: 0x06007F44 RID: 32580 RVA: 0x00150368 File Offset: 0x0014E568
		// (set) Token: 0x06007F45 RID: 32581 RVA: 0x00150370 File Offset: 0x0014E570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FIPNNGPAFCA BEDINILDMEB
		{
			get
			{
				return this.bEDINILDMEB_;
			}
			set
			{
				this.bEDINILDMEB_ = value;
			}
		}

		// Token: 0x170023B3 RID: 9139
		// (get) Token: 0x06007F46 RID: 32582 RVA: 0x00150379 File Offset: 0x0014E579
		// (set) Token: 0x06007F47 RID: 32583 RVA: 0x00150381 File Offset: 0x0014E581
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList HMBJIFIGLFI
		{
			get
			{
				return this.hMBJIFIGLFI_;
			}
			set
			{
				this.hMBJIFIGLFI_ = value;
			}
		}

		// Token: 0x170023B4 RID: 9140
		// (get) Token: 0x06007F48 RID: 32584 RVA: 0x0015038A File Offset: 0x0014E58A
		// (set) Token: 0x06007F49 RID: 32585 RVA: 0x00150392 File Offset: 0x0014E592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList ItemList
		{
			get
			{
				return this.itemList_;
			}
			set
			{
				this.itemList_ = value;
			}
		}

		// Token: 0x06007F4A RID: 32586 RVA: 0x0015039B File Offset: 0x0014E59B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyGameSettleScNotify);
		}

		// Token: 0x06007F4B RID: 32587 RVA: 0x001503AC File Offset: 0x0014E5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyGameSettleScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.BEDINILDMEB, other.BEDINILDMEB) && object.Equals(this.HMBJIFIGLFI, other.HMBJIFIGLFI) && object.Equals(this.ItemList, other.ItemList) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007F4C RID: 32588 RVA: 0x00150414 File Offset: 0x0014E614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.bEDINILDMEB_ != null)
			{
				num ^= this.BEDINILDMEB.GetHashCode();
			}
			if (this.hMBJIFIGLFI_ != null)
			{
				num ^= this.HMBJIFIGLFI.GetHashCode();
			}
			if (this.itemList_ != null)
			{
				num ^= this.ItemList.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007F4D RID: 32589 RVA: 0x0015047C File Offset: 0x0014E67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007F4E RID: 32590 RVA: 0x00150484 File Offset: 0x0014E684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007F4F RID: 32591 RVA: 0x00150490 File Offset: 0x0014E690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.hMBJIFIGLFI_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.HMBJIFIGLFI);
			}
			if (this.bEDINILDMEB_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.BEDINILDMEB);
			}
			if (this.itemList_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.ItemList);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007F50 RID: 32592 RVA: 0x00150508 File Offset: 0x0014E708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.bEDINILDMEB_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BEDINILDMEB);
			}
			if (this.hMBJIFIGLFI_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HMBJIFIGLFI);
			}
			if (this.itemList_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ItemList);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007F51 RID: 32593 RVA: 0x00150578 File Offset: 0x0014E778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyGameSettleScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.bEDINILDMEB_ != null)
			{
				if (this.bEDINILDMEB_ == null)
				{
					this.BEDINILDMEB = new FIPNNGPAFCA();
				}
				this.BEDINILDMEB.MergeFrom(other.BEDINILDMEB);
			}
			if (other.hMBJIFIGLFI_ != null)
			{
				if (this.hMBJIFIGLFI_ == null)
				{
					this.HMBJIFIGLFI = new ItemList();
				}
				this.HMBJIFIGLFI.MergeFrom(other.HMBJIFIGLFI);
			}
			if (other.itemList_ != null)
			{
				if (this.itemList_ == null)
				{
					this.ItemList = new ItemList();
				}
				this.ItemList.MergeFrom(other.ItemList);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007F52 RID: 32594 RVA: 0x00150624 File Offset: 0x0014E824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007F53 RID: 32595 RVA: 0x00150630 File Offset: 0x0014E830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 58U)
				{
					if (num != 82U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.itemList_ == null)
							{
								this.ItemList = new ItemList();
							}
							input.ReadMessage(this.ItemList);
						}
					}
					else
					{
						if (this.bEDINILDMEB_ == null)
						{
							this.BEDINILDMEB = new FIPNNGPAFCA();
						}
						input.ReadMessage(this.BEDINILDMEB);
					}
				}
				else
				{
					if (this.hMBJIFIGLFI_ == null)
					{
						this.HMBJIFIGLFI = new ItemList();
					}
					input.ReadMessage(this.HMBJIFIGLFI);
				}
			}
		}

		// Token: 0x040030BD RID: 12477
		private static readonly MessageParser<MonopolyGameSettleScNotify> _parser = new MessageParser<MonopolyGameSettleScNotify>(() => new MonopolyGameSettleScNotify());

		// Token: 0x040030BE RID: 12478
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030BF RID: 12479
		public const int BEDINILDMEBFieldNumber = 10;

		// Token: 0x040030C0 RID: 12480
		private FIPNNGPAFCA bEDINILDMEB_;

		// Token: 0x040030C1 RID: 12481
		public const int HMBJIFIGLFIFieldNumber = 7;

		// Token: 0x040030C2 RID: 12482
		private ItemList hMBJIFIGLFI_;

		// Token: 0x040030C3 RID: 12483
		public const int ItemListFieldNumber = 15;

		// Token: 0x040030C4 RID: 12484
		private ItemList itemList_;
	}
}
