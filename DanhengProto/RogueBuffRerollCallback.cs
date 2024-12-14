using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E23 RID: 3619
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueBuffRerollCallback : IMessage<RogueBuffRerollCallback>, IMessage, IEquatable<RogueBuffRerollCallback>, IDeepCloneable<RogueBuffRerollCallback>, IBufferMessage
	{
		// Token: 0x17002D99 RID: 11673
		// (get) Token: 0x0600A198 RID: 41368 RVA: 0x001B107B File Offset: 0x001AF27B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueBuffRerollCallback> Parser
		{
			get
			{
				return RogueBuffRerollCallback._parser;
			}
		}

		// Token: 0x17002D9A RID: 11674
		// (get) Token: 0x0600A199 RID: 41369 RVA: 0x001B1082 File Offset: 0x001AF282
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueBuffRerollCallbackReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002D9B RID: 11675
		// (get) Token: 0x0600A19A RID: 41370 RVA: 0x001B1094 File Offset: 0x001AF294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueBuffRerollCallback.Descriptor;
			}
		}

		// Token: 0x0600A19B RID: 41371 RVA: 0x001B109B File Offset: 0x001AF29B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuffRerollCallback()
		{
		}

		// Token: 0x0600A19C RID: 41372 RVA: 0x001B10A3 File Offset: 0x001AF2A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuffRerollCallback(RogueBuffRerollCallback other) : this()
		{
			this.buffSelectInfo_ = ((other.buffSelectInfo_ != null) ? other.buffSelectInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A19D RID: 41373 RVA: 0x001B10D8 File Offset: 0x001AF2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuffRerollCallback Clone()
		{
			return new RogueBuffRerollCallback(this);
		}

		// Token: 0x17002D9C RID: 11676
		// (get) Token: 0x0600A19E RID: 41374 RVA: 0x001B10E0 File Offset: 0x001AF2E0
		// (set) Token: 0x0600A19F RID: 41375 RVA: 0x001B10E8 File Offset: 0x001AF2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonBuffSelectInfo BuffSelectInfo
		{
			get
			{
				return this.buffSelectInfo_;
			}
			set
			{
				this.buffSelectInfo_ = value;
			}
		}

		// Token: 0x0600A1A0 RID: 41376 RVA: 0x001B10F1 File Offset: 0x001AF2F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueBuffRerollCallback);
		}

		// Token: 0x0600A1A1 RID: 41377 RVA: 0x001B10FF File Offset: 0x001AF2FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueBuffRerollCallback other)
		{
			return other != null && (other == this || (object.Equals(this.BuffSelectInfo, other.BuffSelectInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A1A2 RID: 41378 RVA: 0x001B1134 File Offset: 0x001AF334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.buffSelectInfo_ != null)
			{
				num ^= this.BuffSelectInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A1A3 RID: 41379 RVA: 0x001B1170 File Offset: 0x001AF370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A1A4 RID: 41380 RVA: 0x001B1178 File Offset: 0x001AF378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A1A5 RID: 41381 RVA: 0x001B1181 File Offset: 0x001AF381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.buffSelectInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.BuffSelectInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A1A6 RID: 41382 RVA: 0x001B11B4 File Offset: 0x001AF3B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.buffSelectInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BuffSelectInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A1A7 RID: 41383 RVA: 0x001B11F4 File Offset: 0x001AF3F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueBuffRerollCallback other)
		{
			if (other == null)
			{
				return;
			}
			if (other.buffSelectInfo_ != null)
			{
				if (this.buffSelectInfo_ == null)
				{
					this.BuffSelectInfo = new RogueCommonBuffSelectInfo();
				}
				this.BuffSelectInfo.MergeFrom(other.BuffSelectInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A1A8 RID: 41384 RVA: 0x001B1248 File Offset: 0x001AF448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A1A9 RID: 41385 RVA: 0x001B1254 File Offset: 0x001AF454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.buffSelectInfo_ == null)
					{
						this.BuffSelectInfo = new RogueCommonBuffSelectInfo();
					}
					input.ReadMessage(this.BuffSelectInfo);
				}
			}
		}

		// Token: 0x0400421A RID: 16922
		private static readonly MessageParser<RogueBuffRerollCallback> _parser = new MessageParser<RogueBuffRerollCallback>(() => new RogueBuffRerollCallback());

		// Token: 0x0400421B RID: 16923
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400421C RID: 16924
		public const int BuffSelectInfoFieldNumber = 3;

		// Token: 0x0400421D RID: 16925
		private RogueCommonBuffSelectInfo buffSelectInfo_;
	}
}
