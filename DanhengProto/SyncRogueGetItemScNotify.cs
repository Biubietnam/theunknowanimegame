using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001291 RID: 4753
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncRogueGetItemScNotify : IMessage<SyncRogueGetItemScNotify>, IMessage, IEquatable<SyncRogueGetItemScNotify>, IDeepCloneable<SyncRogueGetItemScNotify>, IBufferMessage
	{
		// Token: 0x17003BA6 RID: 15270
		// (get) Token: 0x0600D409 RID: 54281 RVA: 0x002361DB File Offset: 0x002343DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncRogueGetItemScNotify> Parser
		{
			get
			{
				return SyncRogueGetItemScNotify._parser;
			}
		}

		// Token: 0x17003BA7 RID: 15271
		// (get) Token: 0x0600D40A RID: 54282 RVA: 0x002361E2 File Offset: 0x002343E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncRogueGetItemScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003BA8 RID: 15272
		// (get) Token: 0x0600D40B RID: 54283 RVA: 0x002361F4 File Offset: 0x002343F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncRogueGetItemScNotify.Descriptor;
			}
		}

		// Token: 0x0600D40C RID: 54284 RVA: 0x002361FB File Offset: 0x002343FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueGetItemScNotify()
		{
		}

		// Token: 0x0600D40D RID: 54285 RVA: 0x00236204 File Offset: 0x00234404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueGetItemScNotify(SyncRogueGetItemScNotify other) : this()
		{
			this.getItemList_ = ((other.getItemList_ != null) ? other.getItemList_.Clone() : null);
			this.aLLDOIJDHCK_ = ((other.aLLDOIJDHCK_ != null) ? other.aLLDOIJDHCK_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D40E RID: 54286 RVA: 0x00236260 File Offset: 0x00234460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueGetItemScNotify Clone()
		{
			return new SyncRogueGetItemScNotify(this);
		}

		// Token: 0x17003BA9 RID: 15273
		// (get) Token: 0x0600D40F RID: 54287 RVA: 0x00236268 File Offset: 0x00234468
		// (set) Token: 0x0600D410 RID: 54288 RVA: 0x00236270 File Offset: 0x00234470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList GetItemList
		{
			get
			{
				return this.getItemList_;
			}
			set
			{
				this.getItemList_ = value;
			}
		}

		// Token: 0x17003BAA RID: 15274
		// (get) Token: 0x0600D411 RID: 54289 RVA: 0x00236279 File Offset: 0x00234479
		// (set) Token: 0x0600D412 RID: 54290 RVA: 0x00236281 File Offset: 0x00234481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList ALLDOIJDHCK
		{
			get
			{
				return this.aLLDOIJDHCK_;
			}
			set
			{
				this.aLLDOIJDHCK_ = value;
			}
		}

		// Token: 0x0600D413 RID: 54291 RVA: 0x0023628A File Offset: 0x0023448A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncRogueGetItemScNotify);
		}

		// Token: 0x0600D414 RID: 54292 RVA: 0x00236298 File Offset: 0x00234498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncRogueGetItemScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.GetItemList, other.GetItemList) && object.Equals(this.ALLDOIJDHCK, other.ALLDOIJDHCK) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D415 RID: 54293 RVA: 0x002362EC File Offset: 0x002344EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.getItemList_ != null)
			{
				num ^= this.GetItemList.GetHashCode();
			}
			if (this.aLLDOIJDHCK_ != null)
			{
				num ^= this.ALLDOIJDHCK.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D416 RID: 54294 RVA: 0x0023633E File Offset: 0x0023453E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D417 RID: 54295 RVA: 0x00236346 File Offset: 0x00234546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D418 RID: 54296 RVA: 0x00236350 File Offset: 0x00234550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.aLLDOIJDHCK_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ALLDOIJDHCK);
			}
			if (this.getItemList_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.GetItemList);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D419 RID: 54297 RVA: 0x002363AC File Offset: 0x002345AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.getItemList_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GetItemList);
			}
			if (this.aLLDOIJDHCK_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ALLDOIJDHCK);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D41A RID: 54298 RVA: 0x00236404 File Offset: 0x00234604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncRogueGetItemScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.getItemList_ != null)
			{
				if (this.getItemList_ == null)
				{
					this.GetItemList = new ItemList();
				}
				this.GetItemList.MergeFrom(other.GetItemList);
			}
			if (other.aLLDOIJDHCK_ != null)
			{
				if (this.aLLDOIJDHCK_ == null)
				{
					this.ALLDOIJDHCK = new ItemList();
				}
				this.ALLDOIJDHCK.MergeFrom(other.ALLDOIJDHCK);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D41B RID: 54299 RVA: 0x00236484 File Offset: 0x00234684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D41C RID: 54300 RVA: 0x00236490 File Offset: 0x00234690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.getItemList_ == null)
						{
							this.GetItemList = new ItemList();
						}
						input.ReadMessage(this.GetItemList);
					}
				}
				else
				{
					if (this.aLLDOIJDHCK_ == null)
					{
						this.ALLDOIJDHCK = new ItemList();
					}
					input.ReadMessage(this.ALLDOIJDHCK);
				}
			}
		}

		// Token: 0x040054D7 RID: 21719
		private static readonly MessageParser<SyncRogueGetItemScNotify> _parser = new MessageParser<SyncRogueGetItemScNotify>(() => new SyncRogueGetItemScNotify());

		// Token: 0x040054D8 RID: 21720
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054D9 RID: 21721
		public const int GetItemListFieldNumber = 14;

		// Token: 0x040054DA RID: 21722
		private ItemList getItemList_;

		// Token: 0x040054DB RID: 21723
		public const int ALLDOIJDHCKFieldNumber = 2;

		// Token: 0x040054DC RID: 21724
		private ItemList aLLDOIJDHCK_;
	}
}
