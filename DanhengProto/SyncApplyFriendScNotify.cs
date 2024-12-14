using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001263 RID: 4707
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncApplyFriendScNotify : IMessage<SyncApplyFriendScNotify>, IMessage, IEquatable<SyncApplyFriendScNotify>, IDeepCloneable<SyncApplyFriendScNotify>, IBufferMessage
	{
		// Token: 0x17003B2A RID: 15146
		// (get) Token: 0x0600D225 RID: 53797 RVA: 0x00231C1D File Offset: 0x0022FE1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncApplyFriendScNotify> Parser
		{
			get
			{
				return SyncApplyFriendScNotify._parser;
			}
		}

		// Token: 0x17003B2B RID: 15147
		// (get) Token: 0x0600D226 RID: 53798 RVA: 0x00231C24 File Offset: 0x0022FE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncApplyFriendScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003B2C RID: 15148
		// (get) Token: 0x0600D227 RID: 53799 RVA: 0x00231C36 File Offset: 0x0022FE36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncApplyFriendScNotify.Descriptor;
			}
		}

		// Token: 0x0600D228 RID: 53800 RVA: 0x00231C3D File Offset: 0x0022FE3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncApplyFriendScNotify()
		{
		}

		// Token: 0x0600D229 RID: 53801 RVA: 0x00231C45 File Offset: 0x0022FE45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncApplyFriendScNotify(SyncApplyFriendScNotify other) : this()
		{
			this.applyInfo_ = ((other.applyInfo_ != null) ? other.applyInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D22A RID: 53802 RVA: 0x00231C7A File Offset: 0x0022FE7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncApplyFriendScNotify Clone()
		{
			return new SyncApplyFriendScNotify(this);
		}

		// Token: 0x17003B2D RID: 15149
		// (get) Token: 0x0600D22B RID: 53803 RVA: 0x00231C82 File Offset: 0x0022FE82
		// (set) Token: 0x0600D22C RID: 53804 RVA: 0x00231C8A File Offset: 0x0022FE8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplyInfo ApplyInfo
		{
			get
			{
				return this.applyInfo_;
			}
			set
			{
				this.applyInfo_ = value;
			}
		}

		// Token: 0x0600D22D RID: 53805 RVA: 0x00231C93 File Offset: 0x0022FE93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncApplyFriendScNotify);
		}

		// Token: 0x0600D22E RID: 53806 RVA: 0x00231CA1 File Offset: 0x0022FEA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncApplyFriendScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ApplyInfo, other.ApplyInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D22F RID: 53807 RVA: 0x00231CD4 File Offset: 0x0022FED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.applyInfo_ != null)
			{
				num ^= this.ApplyInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D230 RID: 53808 RVA: 0x00231D10 File Offset: 0x0022FF10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D231 RID: 53809 RVA: 0x00231D18 File Offset: 0x0022FF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D232 RID: 53810 RVA: 0x00231D21 File Offset: 0x0022FF21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.applyInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.ApplyInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D233 RID: 53811 RVA: 0x00231D54 File Offset: 0x0022FF54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.applyInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ApplyInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D234 RID: 53812 RVA: 0x00231D94 File Offset: 0x0022FF94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncApplyFriendScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.applyInfo_ != null)
			{
				if (this.applyInfo_ == null)
				{
					this.ApplyInfo = new FriendApplyInfo();
				}
				this.ApplyInfo.MergeFrom(other.ApplyInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D235 RID: 53813 RVA: 0x00231DE8 File Offset: 0x0022FFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D236 RID: 53814 RVA: 0x00231DF4 File Offset: 0x0022FFF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.applyInfo_ == null)
					{
						this.ApplyInfo = new FriendApplyInfo();
					}
					input.ReadMessage(this.ApplyInfo);
				}
			}
		}

		// Token: 0x04005442 RID: 21570
		private static readonly MessageParser<SyncApplyFriendScNotify> _parser = new MessageParser<SyncApplyFriendScNotify>(() => new SyncApplyFriendScNotify());

		// Token: 0x04005443 RID: 21571
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005444 RID: 21572
		public const int ApplyInfoFieldNumber = 12;

		// Token: 0x04005445 RID: 21573
		private FriendApplyInfo applyInfo_;
	}
}
