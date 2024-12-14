using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200128F RID: 4751
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncRogueFinishScNotify : IMessage<SyncRogueFinishScNotify>, IMessage, IEquatable<SyncRogueFinishScNotify>, IDeepCloneable<SyncRogueFinishScNotify>, IBufferMessage
	{
		// Token: 0x17003BA1 RID: 15265
		// (get) Token: 0x0600D3F4 RID: 54260 RVA: 0x00235EF5 File Offset: 0x002340F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncRogueFinishScNotify> Parser
		{
			get
			{
				return SyncRogueFinishScNotify._parser;
			}
		}

		// Token: 0x17003BA2 RID: 15266
		// (get) Token: 0x0600D3F5 RID: 54261 RVA: 0x00235EFC File Offset: 0x002340FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncRogueFinishScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003BA3 RID: 15267
		// (get) Token: 0x0600D3F6 RID: 54262 RVA: 0x00235F0E File Offset: 0x0023410E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncRogueFinishScNotify.Descriptor;
			}
		}

		// Token: 0x0600D3F7 RID: 54263 RVA: 0x00235F15 File Offset: 0x00234115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueFinishScNotify()
		{
		}

		// Token: 0x0600D3F8 RID: 54264 RVA: 0x00235F1D File Offset: 0x0023411D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueFinishScNotify(SyncRogueFinishScNotify other) : this()
		{
			this.rogueFinishInfo_ = ((other.rogueFinishInfo_ != null) ? other.rogueFinishInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D3F9 RID: 54265 RVA: 0x00235F52 File Offset: 0x00234152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueFinishScNotify Clone()
		{
			return new SyncRogueFinishScNotify(this);
		}

		// Token: 0x17003BA4 RID: 15268
		// (get) Token: 0x0600D3FA RID: 54266 RVA: 0x00235F5A File Offset: 0x0023415A
		// (set) Token: 0x0600D3FB RID: 54267 RVA: 0x00235F62 File Offset: 0x00234162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueFinishInfo RogueFinishInfo
		{
			get
			{
				return this.rogueFinishInfo_;
			}
			set
			{
				this.rogueFinishInfo_ = value;
			}
		}

		// Token: 0x0600D3FC RID: 54268 RVA: 0x00235F6B File Offset: 0x0023416B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncRogueFinishScNotify);
		}

		// Token: 0x0600D3FD RID: 54269 RVA: 0x00235F79 File Offset: 0x00234179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncRogueFinishScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.RogueFinishInfo, other.RogueFinishInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D3FE RID: 54270 RVA: 0x00235FAC File Offset: 0x002341AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueFinishInfo_ != null)
			{
				num ^= this.RogueFinishInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D3FF RID: 54271 RVA: 0x00235FE8 File Offset: 0x002341E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D400 RID: 54272 RVA: 0x00235FF0 File Offset: 0x002341F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D401 RID: 54273 RVA: 0x00235FF9 File Offset: 0x002341F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueFinishInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.RogueFinishInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D402 RID: 54274 RVA: 0x0023602C File Offset: 0x0023422C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueFinishInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueFinishInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D403 RID: 54275 RVA: 0x0023606C File Offset: 0x0023426C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncRogueFinishScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueFinishInfo_ != null)
			{
				if (this.rogueFinishInfo_ == null)
				{
					this.RogueFinishInfo = new RogueFinishInfo();
				}
				this.RogueFinishInfo.MergeFrom(other.RogueFinishInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D404 RID: 54276 RVA: 0x002360C0 File Offset: 0x002342C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D405 RID: 54277 RVA: 0x002360CC File Offset: 0x002342CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.rogueFinishInfo_ == null)
					{
						this.RogueFinishInfo = new RogueFinishInfo();
					}
					input.ReadMessage(this.RogueFinishInfo);
				}
			}
		}

		// Token: 0x040054D2 RID: 21714
		private static readonly MessageParser<SyncRogueFinishScNotify> _parser = new MessageParser<SyncRogueFinishScNotify>(() => new SyncRogueFinishScNotify());

		// Token: 0x040054D3 RID: 21715
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054D4 RID: 21716
		public const int RogueFinishInfoFieldNumber = 7;

		// Token: 0x040054D5 RID: 21717
		private RogueFinishInfo rogueFinishInfo_;
	}
}
