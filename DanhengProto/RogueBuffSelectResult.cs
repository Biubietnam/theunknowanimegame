using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E29 RID: 3625
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueBuffSelectResult : IMessage<RogueBuffSelectResult>, IMessage, IEquatable<RogueBuffSelectResult>, IDeepCloneable<RogueBuffSelectResult>, IBufferMessage
	{
		// Token: 0x17002DA6 RID: 11686
		// (get) Token: 0x0600A1D3 RID: 41427 RVA: 0x001B169C File Offset: 0x001AF89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueBuffSelectResult> Parser
		{
			get
			{
				return RogueBuffSelectResult._parser;
			}
		}

		// Token: 0x17002DA7 RID: 11687
		// (get) Token: 0x0600A1D4 RID: 41428 RVA: 0x001B16A3 File Offset: 0x001AF8A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueBuffSelectResultReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002DA8 RID: 11688
		// (get) Token: 0x0600A1D5 RID: 41429 RVA: 0x001B16B5 File Offset: 0x001AF8B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueBuffSelectResult.Descriptor;
			}
		}

		// Token: 0x0600A1D6 RID: 41430 RVA: 0x001B16BC File Offset: 0x001AF8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuffSelectResult()
		{
		}

		// Token: 0x0600A1D7 RID: 41431 RVA: 0x001B16C4 File Offset: 0x001AF8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuffSelectResult(RogueBuffSelectResult other) : this()
		{
			this.buffSelectId_ = other.buffSelectId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A1D8 RID: 41432 RVA: 0x001B16E9 File Offset: 0x001AF8E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuffSelectResult Clone()
		{
			return new RogueBuffSelectResult(this);
		}

		// Token: 0x17002DA9 RID: 11689
		// (get) Token: 0x0600A1D9 RID: 41433 RVA: 0x001B16F1 File Offset: 0x001AF8F1
		// (set) Token: 0x0600A1DA RID: 41434 RVA: 0x001B16F9 File Offset: 0x001AF8F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BuffSelectId
		{
			get
			{
				return this.buffSelectId_;
			}
			set
			{
				this.buffSelectId_ = value;
			}
		}

		// Token: 0x0600A1DB RID: 41435 RVA: 0x001B1702 File Offset: 0x001AF902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueBuffSelectResult);
		}

		// Token: 0x0600A1DC RID: 41436 RVA: 0x001B1710 File Offset: 0x001AF910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueBuffSelectResult other)
		{
			return other != null && (other == this || (this.BuffSelectId == other.BuffSelectId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A1DD RID: 41437 RVA: 0x001B1740 File Offset: 0x001AF940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuffSelectId != 0U)
			{
				num ^= this.BuffSelectId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A1DE RID: 41438 RVA: 0x001B177F File Offset: 0x001AF97F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A1DF RID: 41439 RVA: 0x001B1787 File Offset: 0x001AF987
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A1E0 RID: 41440 RVA: 0x001B1790 File Offset: 0x001AF990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuffSelectId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.BuffSelectId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A1E1 RID: 41441 RVA: 0x001B17C4 File Offset: 0x001AF9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuffSelectId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BuffSelectId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A1E2 RID: 41442 RVA: 0x001B1802 File Offset: 0x001AFA02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueBuffSelectResult other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuffSelectId != 0U)
			{
				this.BuffSelectId = other.BuffSelectId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A1E3 RID: 41443 RVA: 0x001B1833 File Offset: 0x001AFA33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A1E4 RID: 41444 RVA: 0x001B183C File Offset: 0x001AFA3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.BuffSelectId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004225 RID: 16933
		private static readonly MessageParser<RogueBuffSelectResult> _parser = new MessageParser<RogueBuffSelectResult>(() => new RogueBuffSelectResult());

		// Token: 0x04004226 RID: 16934
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004227 RID: 16935
		public const int BuffSelectIdFieldNumber = 11;

		// Token: 0x04004228 RID: 16936
		private uint buffSelectId_;
	}
}
