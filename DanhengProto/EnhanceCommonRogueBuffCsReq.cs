using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000423 RID: 1059
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnhanceCommonRogueBuffCsReq : IMessage<EnhanceCommonRogueBuffCsReq>, IMessage, IEquatable<EnhanceCommonRogueBuffCsReq>, IDeepCloneable<EnhanceCommonRogueBuffCsReq>, IBufferMessage
	{
		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x06002F10 RID: 12048 RVA: 0x00081FE5 File Offset: 0x000801E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnhanceCommonRogueBuffCsReq> Parser
		{
			get
			{
				return EnhanceCommonRogueBuffCsReq._parser;
			}
		}

		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x06002F11 RID: 12049 RVA: 0x00081FEC File Offset: 0x000801EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnhanceCommonRogueBuffCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x06002F12 RID: 12050 RVA: 0x00081FFE File Offset: 0x000801FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnhanceCommonRogueBuffCsReq.Descriptor;
			}
		}

		// Token: 0x06002F13 RID: 12051 RVA: 0x00082005 File Offset: 0x00080205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnhanceCommonRogueBuffCsReq()
		{
		}

		// Token: 0x06002F14 RID: 12052 RVA: 0x0008200D File Offset: 0x0008020D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnhanceCommonRogueBuffCsReq(EnhanceCommonRogueBuffCsReq other) : this()
		{
			this.mazeBuffId_ = other.mazeBuffId_;
			this.interactedPropEntityId_ = other.interactedPropEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002F15 RID: 12053 RVA: 0x0008203E File Offset: 0x0008023E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnhanceCommonRogueBuffCsReq Clone()
		{
			return new EnhanceCommonRogueBuffCsReq(this);
		}

		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x06002F16 RID: 12054 RVA: 0x00082046 File Offset: 0x00080246
		// (set) Token: 0x06002F17 RID: 12055 RVA: 0x0008204E File Offset: 0x0008024E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MazeBuffId
		{
			get
			{
				return this.mazeBuffId_;
			}
			set
			{
				this.mazeBuffId_ = value;
			}
		}

		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x06002F18 RID: 12056 RVA: 0x00082057 File Offset: 0x00080257
		// (set) Token: 0x06002F19 RID: 12057 RVA: 0x0008205F File Offset: 0x0008025F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint InteractedPropEntityId
		{
			get
			{
				return this.interactedPropEntityId_;
			}
			set
			{
				this.interactedPropEntityId_ = value;
			}
		}

		// Token: 0x06002F1A RID: 12058 RVA: 0x00082068 File Offset: 0x00080268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnhanceCommonRogueBuffCsReq);
		}

		// Token: 0x06002F1B RID: 12059 RVA: 0x00082076 File Offset: 0x00080276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnhanceCommonRogueBuffCsReq other)
		{
			return other != null && (other == this || (this.MazeBuffId == other.MazeBuffId && this.InteractedPropEntityId == other.InteractedPropEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002F1C RID: 12060 RVA: 0x000820B4 File Offset: 0x000802B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MazeBuffId != 0U)
			{
				num ^= this.MazeBuffId.GetHashCode();
			}
			if (this.InteractedPropEntityId != 0U)
			{
				num ^= this.InteractedPropEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002F1D RID: 12061 RVA: 0x0008210C File Offset: 0x0008030C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002F1E RID: 12062 RVA: 0x00082114 File Offset: 0x00080314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002F1F RID: 12063 RVA: 0x00082120 File Offset: 0x00080320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MazeBuffId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.MazeBuffId);
			}
			if (this.InteractedPropEntityId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.InteractedPropEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002F20 RID: 12064 RVA: 0x0008217C File Offset: 0x0008037C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MazeBuffId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MazeBuffId);
			}
			if (this.InteractedPropEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.InteractedPropEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002F21 RID: 12065 RVA: 0x000821D4 File Offset: 0x000803D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnhanceCommonRogueBuffCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MazeBuffId != 0U)
			{
				this.MazeBuffId = other.MazeBuffId;
			}
			if (other.InteractedPropEntityId != 0U)
			{
				this.InteractedPropEntityId = other.InteractedPropEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002F22 RID: 12066 RVA: 0x00082224 File Offset: 0x00080424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002F23 RID: 12067 RVA: 0x00082230 File Offset: 0x00080430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.InteractedPropEntityId = input.ReadUInt32();
					}
				}
				else
				{
					this.MazeBuffId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040012DF RID: 4831
		private static readonly MessageParser<EnhanceCommonRogueBuffCsReq> _parser = new MessageParser<EnhanceCommonRogueBuffCsReq>(() => new EnhanceCommonRogueBuffCsReq());

		// Token: 0x040012E0 RID: 4832
		private UnknownFieldSet _unknownFields;

		// Token: 0x040012E1 RID: 4833
		public const int MazeBuffIdFieldNumber = 2;

		// Token: 0x040012E2 RID: 4834
		private uint mazeBuffId_;

		// Token: 0x040012E3 RID: 4835
		public const int InteractedPropEntityIdFieldNumber = 13;

		// Token: 0x040012E4 RID: 4836
		private uint interactedPropEntityId_;
	}
}
