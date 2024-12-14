using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002B9 RID: 697
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueUpdateReviveInfoScNotify : IMessage<ChessRogueUpdateReviveInfoScNotify>, IMessage, IEquatable<ChessRogueUpdateReviveInfoScNotify>, IDeepCloneable<ChessRogueUpdateReviveInfoScNotify>, IBufferMessage
	{
		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06001F0B RID: 7947 RVA: 0x00058AD7 File Offset: 0x00056CD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueUpdateReviveInfoScNotify> Parser
		{
			get
			{
				return ChessRogueUpdateReviveInfoScNotify._parser;
			}
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06001F0C RID: 7948 RVA: 0x00058ADE File Offset: 0x00056CDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueUpdateReviveInfoScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06001F0D RID: 7949 RVA: 0x00058AF0 File Offset: 0x00056CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueUpdateReviveInfoScNotify.Descriptor;
			}
		}

		// Token: 0x06001F0E RID: 7950 RVA: 0x00058AF7 File Offset: 0x00056CF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueUpdateReviveInfoScNotify()
		{
		}

		// Token: 0x06001F0F RID: 7951 RVA: 0x00058AFF File Offset: 0x00056CFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueUpdateReviveInfoScNotify(ChessRogueUpdateReviveInfoScNotify other) : this()
		{
			this.reviveInfo_ = ((other.reviveInfo_ != null) ? other.reviveInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001F10 RID: 7952 RVA: 0x00058B34 File Offset: 0x00056D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueUpdateReviveInfoScNotify Clone()
		{
			return new ChessRogueUpdateReviveInfoScNotify(this);
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06001F11 RID: 7953 RVA: 0x00058B3C File Offset: 0x00056D3C
		// (set) Token: 0x06001F12 RID: 7954 RVA: 0x00058B44 File Offset: 0x00056D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAvatarReviveCost ReviveInfo
		{
			get
			{
				return this.reviveInfo_;
			}
			set
			{
				this.reviveInfo_ = value;
			}
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x00058B4D File Offset: 0x00056D4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueUpdateReviveInfoScNotify);
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x00058B5B File Offset: 0x00056D5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueUpdateReviveInfoScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ReviveInfo, other.ReviveInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x00058B90 File Offset: 0x00056D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.reviveInfo_ != null)
			{
				num ^= this.ReviveInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001F16 RID: 7958 RVA: 0x00058BCC File Offset: 0x00056DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001F17 RID: 7959 RVA: 0x00058BD4 File Offset: 0x00056DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001F18 RID: 7960 RVA: 0x00058BDD File Offset: 0x00056DDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.reviveInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.ReviveInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x00058C10 File Offset: 0x00056E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.reviveInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ReviveInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x00058C50 File Offset: 0x00056E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueUpdateReviveInfoScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.reviveInfo_ != null)
			{
				if (this.reviveInfo_ == null)
				{
					this.ReviveInfo = new RogueAvatarReviveCost();
				}
				this.ReviveInfo.MergeFrom(other.ReviveInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001F1B RID: 7963 RVA: 0x00058CA4 File Offset: 0x00056EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001F1C RID: 7964 RVA: 0x00058CB0 File Offset: 0x00056EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.reviveInfo_ == null)
					{
						this.ReviveInfo = new RogueAvatarReviveCost();
					}
					input.ReadMessage(this.ReviveInfo);
				}
			}
		}

		// Token: 0x04000CE4 RID: 3300
		private static readonly MessageParser<ChessRogueUpdateReviveInfoScNotify> _parser = new MessageParser<ChessRogueUpdateReviveInfoScNotify>(() => new ChessRogueUpdateReviveInfoScNotify());

		// Token: 0x04000CE5 RID: 3301
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000CE6 RID: 3302
		public const int ReviveInfoFieldNumber = 5;

		// Token: 0x04000CE7 RID: 3303
		private RogueAvatarReviveCost reviveInfo_;
	}
}
