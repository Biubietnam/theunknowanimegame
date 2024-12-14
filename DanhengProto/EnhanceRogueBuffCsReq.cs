using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000427 RID: 1063
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnhanceRogueBuffCsReq : IMessage<EnhanceRogueBuffCsReq>, IMessage, IEquatable<EnhanceRogueBuffCsReq>, IDeepCloneable<EnhanceRogueBuffCsReq>, IBufferMessage
	{
		// Token: 0x17000D84 RID: 3460
		// (get) Token: 0x06002F40 RID: 12096 RVA: 0x00082760 File Offset: 0x00080960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnhanceRogueBuffCsReq> Parser
		{
			get
			{
				return EnhanceRogueBuffCsReq._parser;
			}
		}

		// Token: 0x17000D85 RID: 3461
		// (get) Token: 0x06002F41 RID: 12097 RVA: 0x00082767 File Offset: 0x00080967
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnhanceRogueBuffCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000D86 RID: 3462
		// (get) Token: 0x06002F42 RID: 12098 RVA: 0x00082779 File Offset: 0x00080979
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnhanceRogueBuffCsReq.Descriptor;
			}
		}

		// Token: 0x06002F43 RID: 12099 RVA: 0x00082780 File Offset: 0x00080980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnhanceRogueBuffCsReq()
		{
		}

		// Token: 0x06002F44 RID: 12100 RVA: 0x00082788 File Offset: 0x00080988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnhanceRogueBuffCsReq(EnhanceRogueBuffCsReq other) : this()
		{
			this.mazeBuffId_ = other.mazeBuffId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002F45 RID: 12101 RVA: 0x000827AD File Offset: 0x000809AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnhanceRogueBuffCsReq Clone()
		{
			return new EnhanceRogueBuffCsReq(this);
		}

		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x06002F46 RID: 12102 RVA: 0x000827B5 File Offset: 0x000809B5
		// (set) Token: 0x06002F47 RID: 12103 RVA: 0x000827BD File Offset: 0x000809BD
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

		// Token: 0x06002F48 RID: 12104 RVA: 0x000827C6 File Offset: 0x000809C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnhanceRogueBuffCsReq);
		}

		// Token: 0x06002F49 RID: 12105 RVA: 0x000827D4 File Offset: 0x000809D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnhanceRogueBuffCsReq other)
		{
			return other != null && (other == this || (this.MazeBuffId == other.MazeBuffId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002F4A RID: 12106 RVA: 0x00082804 File Offset: 0x00080A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MazeBuffId != 0U)
			{
				num ^= this.MazeBuffId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002F4B RID: 12107 RVA: 0x00082843 File Offset: 0x00080A43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002F4C RID: 12108 RVA: 0x0008284B File Offset: 0x00080A4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002F4D RID: 12109 RVA: 0x00082854 File Offset: 0x00080A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MazeBuffId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.MazeBuffId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002F4E RID: 12110 RVA: 0x00082888 File Offset: 0x00080A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MazeBuffId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MazeBuffId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002F4F RID: 12111 RVA: 0x000828C6 File Offset: 0x00080AC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnhanceRogueBuffCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MazeBuffId != 0U)
			{
				this.MazeBuffId = other.MazeBuffId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002F50 RID: 12112 RVA: 0x000828F7 File Offset: 0x00080AF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002F51 RID: 12113 RVA: 0x00082900 File Offset: 0x00080B00
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
					this.MazeBuffId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040012EF RID: 4847
		private static readonly MessageParser<EnhanceRogueBuffCsReq> _parser = new MessageParser<EnhanceRogueBuffCsReq>(() => new EnhanceRogueBuffCsReq());

		// Token: 0x040012F0 RID: 4848
		private UnknownFieldSet _unknownFields;

		// Token: 0x040012F1 RID: 4849
		public const int MazeBuffIdFieldNumber = 11;

		// Token: 0x040012F2 RID: 4850
		private uint mazeBuffId_;
	}
}
