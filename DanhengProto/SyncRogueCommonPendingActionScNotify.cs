using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001289 RID: 4745
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncRogueCommonPendingActionScNotify : IMessage<SyncRogueCommonPendingActionScNotify>, IMessage, IEquatable<SyncRogueCommonPendingActionScNotify>, IDeepCloneable<SyncRogueCommonPendingActionScNotify>, IBufferMessage
	{
		// Token: 0x17003B91 RID: 15249
		// (get) Token: 0x0600D3B4 RID: 54196 RVA: 0x0023566B File Offset: 0x0023386B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncRogueCommonPendingActionScNotify> Parser
		{
			get
			{
				return SyncRogueCommonPendingActionScNotify._parser;
			}
		}

		// Token: 0x17003B92 RID: 15250
		// (get) Token: 0x0600D3B5 RID: 54197 RVA: 0x00235672 File Offset: 0x00233872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncRogueCommonPendingActionScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003B93 RID: 15251
		// (get) Token: 0x0600D3B6 RID: 54198 RVA: 0x00235684 File Offset: 0x00233884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncRogueCommonPendingActionScNotify.Descriptor;
			}
		}

		// Token: 0x0600D3B7 RID: 54199 RVA: 0x0023568B File Offset: 0x0023388B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueCommonPendingActionScNotify()
		{
		}

		// Token: 0x0600D3B8 RID: 54200 RVA: 0x00235694 File Offset: 0x00233894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueCommonPendingActionScNotify(SyncRogueCommonPendingActionScNotify other) : this()
		{
			this.action_ = ((other.action_ != null) ? other.action_.Clone() : null);
			this.rogueSubMode_ = other.rogueSubMode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D3B9 RID: 54201 RVA: 0x002356E0 File Offset: 0x002338E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueCommonPendingActionScNotify Clone()
		{
			return new SyncRogueCommonPendingActionScNotify(this);
		}

		// Token: 0x17003B94 RID: 15252
		// (get) Token: 0x0600D3BA RID: 54202 RVA: 0x002356E8 File Offset: 0x002338E8
		// (set) Token: 0x0600D3BB RID: 54203 RVA: 0x002356F0 File Offset: 0x002338F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonPendingAction Action
		{
			get
			{
				return this.action_;
			}
			set
			{
				this.action_ = value;
			}
		}

		// Token: 0x17003B95 RID: 15253
		// (get) Token: 0x0600D3BC RID: 54204 RVA: 0x002356F9 File Offset: 0x002338F9
		// (set) Token: 0x0600D3BD RID: 54205 RVA: 0x00235701 File Offset: 0x00233901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RogueSubMode
		{
			get
			{
				return this.rogueSubMode_;
			}
			set
			{
				this.rogueSubMode_ = value;
			}
		}

		// Token: 0x0600D3BE RID: 54206 RVA: 0x0023570A File Offset: 0x0023390A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncRogueCommonPendingActionScNotify);
		}

		// Token: 0x0600D3BF RID: 54207 RVA: 0x00235718 File Offset: 0x00233918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncRogueCommonPendingActionScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Action, other.Action) && this.RogueSubMode == other.RogueSubMode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D3C0 RID: 54208 RVA: 0x00235768 File Offset: 0x00233968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.action_ != null)
			{
				num ^= this.Action.GetHashCode();
			}
			if (this.RogueSubMode != 0U)
			{
				num ^= this.RogueSubMode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D3C1 RID: 54209 RVA: 0x002357BD File Offset: 0x002339BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D3C2 RID: 54210 RVA: 0x002357C5 File Offset: 0x002339C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D3C3 RID: 54211 RVA: 0x002357D0 File Offset: 0x002339D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.action_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Action);
			}
			if (this.RogueSubMode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.RogueSubMode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D3C4 RID: 54212 RVA: 0x0023582C File Offset: 0x00233A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.action_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Action);
			}
			if (this.RogueSubMode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RogueSubMode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D3C5 RID: 54213 RVA: 0x00235884 File Offset: 0x00233A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncRogueCommonPendingActionScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.action_ != null)
			{
				if (this.action_ == null)
				{
					this.Action = new RogueCommonPendingAction();
				}
				this.Action.MergeFrom(other.Action);
			}
			if (other.RogueSubMode != 0U)
			{
				this.RogueSubMode = other.RogueSubMode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D3C6 RID: 54214 RVA: 0x002358EC File Offset: 0x00233AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D3C7 RID: 54215 RVA: 0x002358F8 File Offset: 0x00233AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 90U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RogueSubMode = input.ReadUInt32();
					}
				}
				else
				{
					if (this.action_ == null)
					{
						this.Action = new RogueCommonPendingAction();
					}
					input.ReadMessage(this.Action);
				}
			}
		}

		// Token: 0x040054C0 RID: 21696
		private static readonly MessageParser<SyncRogueCommonPendingActionScNotify> _parser = new MessageParser<SyncRogueCommonPendingActionScNotify>(() => new SyncRogueCommonPendingActionScNotify());

		// Token: 0x040054C1 RID: 21697
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054C2 RID: 21698
		public const int ActionFieldNumber = 11;

		// Token: 0x040054C3 RID: 21699
		private RogueCommonPendingAction action_;

		// Token: 0x040054C4 RID: 21700
		public const int RogueSubModeFieldNumber = 15;

		// Token: 0x040054C5 RID: 21701
		private uint rogueSubMode_;
	}
}
