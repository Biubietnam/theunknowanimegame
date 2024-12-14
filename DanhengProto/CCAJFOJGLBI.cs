using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200016F RID: 367
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CCAJFOJGLBI : IMessage<CCAJFOJGLBI>, IMessage, IEquatable<CCAJFOJGLBI>, IDeepCloneable<CCAJFOJGLBI>, IBufferMessage
	{
		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06001056 RID: 4182 RVA: 0x0002F43C File Offset: 0x0002D63C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CCAJFOJGLBI> Parser
		{
			get
			{
				return CCAJFOJGLBI._parser;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06001057 RID: 4183 RVA: 0x0002F443 File Offset: 0x0002D643
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CCAJFOJGLBIReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06001058 RID: 4184 RVA: 0x0002F455 File Offset: 0x0002D655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CCAJFOJGLBI.Descriptor;
			}
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x0002F45C File Offset: 0x0002D65C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CCAJFOJGLBI()
		{
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x0002F464 File Offset: 0x0002D664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CCAJFOJGLBI(CCAJFOJGLBI other) : this()
		{
			this.lACBICGDLJH_ = other.lACBICGDLJH_;
			this.chessRogueMainStoryId_ = other.chessRogueMainStoryId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x0002F495 File Offset: 0x0002D695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CCAJFOJGLBI Clone()
		{
			return new CCAJFOJGLBI(this);
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x0600105C RID: 4188 RVA: 0x0002F49D File Offset: 0x0002D69D
		// (set) Token: 0x0600105D RID: 4189 RVA: 0x0002F4A5 File Offset: 0x0002D6A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LACBICGDLJH
		{
			get
			{
				return this.lACBICGDLJH_;
			}
			set
			{
				this.lACBICGDLJH_ = value;
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x0600105E RID: 4190 RVA: 0x0002F4AE File Offset: 0x0002D6AE
		// (set) Token: 0x0600105F RID: 4191 RVA: 0x0002F4B6 File Offset: 0x0002D6B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ChessRogueMainStoryId
		{
			get
			{
				return this.chessRogueMainStoryId_;
			}
			set
			{
				this.chessRogueMainStoryId_ = value;
			}
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x0002F4BF File Offset: 0x0002D6BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CCAJFOJGLBI);
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x0002F4CD File Offset: 0x0002D6CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CCAJFOJGLBI other)
		{
			return other != null && (other == this || (this.LACBICGDLJH == other.LACBICGDLJH && this.ChessRogueMainStoryId == other.ChessRogueMainStoryId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x0002F50C File Offset: 0x0002D70C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LACBICGDLJH != 0U)
			{
				num ^= this.LACBICGDLJH.GetHashCode();
			}
			if (this.ChessRogueMainStoryId != 0U)
			{
				num ^= this.ChessRogueMainStoryId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x0002F564 File Offset: 0x0002D764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x0002F56C File Offset: 0x0002D76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x0002F578 File Offset: 0x0002D778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LACBICGDLJH != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.LACBICGDLJH);
			}
			if (this.ChessRogueMainStoryId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.ChessRogueMainStoryId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x0002F5D4 File Offset: 0x0002D7D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LACBICGDLJH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LACBICGDLJH);
			}
			if (this.ChessRogueMainStoryId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChessRogueMainStoryId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x0002F62C File Offset: 0x0002D82C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CCAJFOJGLBI other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LACBICGDLJH != 0U)
			{
				this.LACBICGDLJH = other.LACBICGDLJH;
			}
			if (other.ChessRogueMainStoryId != 0U)
			{
				this.ChessRogueMainStoryId = other.ChessRogueMainStoryId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x0002F67C File Offset: 0x0002D87C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x0002F688 File Offset: 0x0002D888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ChessRogueMainStoryId = input.ReadUInt32();
					}
				}
				else
				{
					this.LACBICGDLJH = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040006DE RID: 1758
		private static readonly MessageParser<CCAJFOJGLBI> _parser = new MessageParser<CCAJFOJGLBI>(() => new CCAJFOJGLBI());

		// Token: 0x040006DF RID: 1759
		private UnknownFieldSet _unknownFields;

		// Token: 0x040006E0 RID: 1760
		public const int LACBICGDLJHFieldNumber = 4;

		// Token: 0x040006E1 RID: 1761
		private uint lACBICGDLJH_;

		// Token: 0x040006E2 RID: 1762
		public const int ChessRogueMainStoryIdFieldNumber = 15;

		// Token: 0x040006E3 RID: 1763
		private uint chessRogueMainStoryId_;
	}
}
