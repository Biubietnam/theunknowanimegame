using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001275 RID: 4725
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncHandleFriendScNotify : IMessage<SyncHandleFriendScNotify>, IMessage, IEquatable<SyncHandleFriendScNotify>, IDeepCloneable<SyncHandleFriendScNotify>, IBufferMessage
	{
		// Token: 0x17003B59 RID: 15193
		// (get) Token: 0x0600D2E4 RID: 53988 RVA: 0x002334F7 File Offset: 0x002316F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncHandleFriendScNotify> Parser
		{
			get
			{
				return SyncHandleFriendScNotify._parser;
			}
		}

		// Token: 0x17003B5A RID: 15194
		// (get) Token: 0x0600D2E5 RID: 53989 RVA: 0x002334FE File Offset: 0x002316FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncHandleFriendScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003B5B RID: 15195
		// (get) Token: 0x0600D2E6 RID: 53990 RVA: 0x00233510 File Offset: 0x00231710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncHandleFriendScNotify.Descriptor;
			}
		}

		// Token: 0x0600D2E7 RID: 53991 RVA: 0x00233517 File Offset: 0x00231717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncHandleFriendScNotify()
		{
		}

		// Token: 0x0600D2E8 RID: 53992 RVA: 0x00233520 File Offset: 0x00231720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncHandleFriendScNotify(SyncHandleFriendScNotify other) : this()
		{
			this.uid_ = other.uid_;
			this.isAccept_ = other.isAccept_;
			this.friendInfo_ = ((other.friendInfo_ != null) ? other.friendInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D2E9 RID: 53993 RVA: 0x00233578 File Offset: 0x00231778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncHandleFriendScNotify Clone()
		{
			return new SyncHandleFriendScNotify(this);
		}

		// Token: 0x17003B5C RID: 15196
		// (get) Token: 0x0600D2EA RID: 53994 RVA: 0x00233580 File Offset: 0x00231780
		// (set) Token: 0x0600D2EB RID: 53995 RVA: 0x00233588 File Offset: 0x00231788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Uid
		{
			get
			{
				return this.uid_;
			}
			set
			{
				this.uid_ = value;
			}
		}

		// Token: 0x17003B5D RID: 15197
		// (get) Token: 0x0600D2EC RID: 53996 RVA: 0x00233591 File Offset: 0x00231791
		// (set) Token: 0x0600D2ED RID: 53997 RVA: 0x00233599 File Offset: 0x00231799
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsAccept
		{
			get
			{
				return this.isAccept_;
			}
			set
			{
				this.isAccept_ = value;
			}
		}

		// Token: 0x17003B5E RID: 15198
		// (get) Token: 0x0600D2EE RID: 53998 RVA: 0x002335A2 File Offset: 0x002317A2
		// (set) Token: 0x0600D2EF RID: 53999 RVA: 0x002335AA File Offset: 0x002317AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendSimpleInfo FriendInfo
		{
			get
			{
				return this.friendInfo_;
			}
			set
			{
				this.friendInfo_ = value;
			}
		}

		// Token: 0x0600D2F0 RID: 54000 RVA: 0x002335B3 File Offset: 0x002317B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncHandleFriendScNotify);
		}

		// Token: 0x0600D2F1 RID: 54001 RVA: 0x002335C4 File Offset: 0x002317C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncHandleFriendScNotify other)
		{
			return other != null && (other == this || (this.Uid == other.Uid && this.IsAccept == other.IsAccept && object.Equals(this.FriendInfo, other.FriendInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D2F2 RID: 54002 RVA: 0x00233624 File Offset: 0x00231824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this.IsAccept)
			{
				num ^= this.IsAccept.GetHashCode();
			}
			if (this.friendInfo_ != null)
			{
				num ^= this.FriendInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D2F3 RID: 54003 RVA: 0x00233692 File Offset: 0x00231892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D2F4 RID: 54004 RVA: 0x0023369A File Offset: 0x0023189A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D2F5 RID: 54005 RVA: 0x002336A4 File Offset: 0x002318A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsAccept)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsAccept);
			}
			if (this.Uid != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Uid);
			}
			if (this.friendInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.FriendInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D2F6 RID: 54006 RVA: 0x0023371C File Offset: 0x0023191C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			if (this.IsAccept)
			{
				num += 2;
			}
			if (this.friendInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FriendInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D2F7 RID: 54007 RVA: 0x00233780 File Offset: 0x00231980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncHandleFriendScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			if (other.IsAccept)
			{
				this.IsAccept = other.IsAccept;
			}
			if (other.friendInfo_ != null)
			{
				if (this.friendInfo_ == null)
				{
					this.FriendInfo = new FriendSimpleInfo();
				}
				this.FriendInfo.MergeFrom(other.FriendInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D2F8 RID: 54008 RVA: 0x002337FC File Offset: 0x002319FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D2F9 RID: 54009 RVA: 0x00233808 File Offset: 0x00231A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					if (num != 96U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.friendInfo_ == null)
							{
								this.FriendInfo = new FriendSimpleInfo();
							}
							input.ReadMessage(this.FriendInfo);
						}
					}
					else
					{
						this.Uid = input.ReadUInt32();
					}
				}
				else
				{
					this.IsAccept = input.ReadBool();
				}
			}
		}

		// Token: 0x04005475 RID: 21621
		private static readonly MessageParser<SyncHandleFriendScNotify> _parser = new MessageParser<SyncHandleFriendScNotify>(() => new SyncHandleFriendScNotify());

		// Token: 0x04005476 RID: 21622
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005477 RID: 21623
		public const int UidFieldNumber = 12;

		// Token: 0x04005478 RID: 21624
		private uint uid_;

		// Token: 0x04005479 RID: 21625
		public const int IsAcceptFieldNumber = 10;

		// Token: 0x0400547A RID: 21626
		private bool isAccept_;

		// Token: 0x0400547B RID: 21627
		public const int FriendInfoFieldNumber = 14;

		// Token: 0x0400547C RID: 21628
		private FriendSimpleInfo friendInfo_;
	}
}
