using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200041F RID: 1055
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnhanceChessRogueBuffCsReq : IMessage<EnhanceChessRogueBuffCsReq>, IMessage, IEquatable<EnhanceChessRogueBuffCsReq>, IDeepCloneable<EnhanceChessRogueBuffCsReq>, IBufferMessage
	{
		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x06002EE0 RID: 12000 RVA: 0x0008180C File Offset: 0x0007FA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnhanceChessRogueBuffCsReq> Parser
		{
			get
			{
				return EnhanceChessRogueBuffCsReq._parser;
			}
		}

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x06002EE1 RID: 12001 RVA: 0x00081813 File Offset: 0x0007FA13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnhanceChessRogueBuffCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x06002EE2 RID: 12002 RVA: 0x00081825 File Offset: 0x0007FA25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnhanceChessRogueBuffCsReq.Descriptor;
			}
		}

		// Token: 0x06002EE3 RID: 12003 RVA: 0x0008182C File Offset: 0x0007FA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnhanceChessRogueBuffCsReq()
		{
		}

		// Token: 0x06002EE4 RID: 12004 RVA: 0x00081834 File Offset: 0x0007FA34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnhanceChessRogueBuffCsReq(EnhanceChessRogueBuffCsReq other) : this()
		{
			this.mazeBuffId_ = other.mazeBuffId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002EE5 RID: 12005 RVA: 0x00081859 File Offset: 0x0007FA59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnhanceChessRogueBuffCsReq Clone()
		{
			return new EnhanceChessRogueBuffCsReq(this);
		}

		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x06002EE6 RID: 12006 RVA: 0x00081861 File Offset: 0x0007FA61
		// (set) Token: 0x06002EE7 RID: 12007 RVA: 0x00081869 File Offset: 0x0007FA69
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

		// Token: 0x06002EE8 RID: 12008 RVA: 0x00081872 File Offset: 0x0007FA72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnhanceChessRogueBuffCsReq);
		}

		// Token: 0x06002EE9 RID: 12009 RVA: 0x00081880 File Offset: 0x0007FA80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnhanceChessRogueBuffCsReq other)
		{
			return other != null && (other == this || (this.MazeBuffId == other.MazeBuffId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002EEA RID: 12010 RVA: 0x000818B0 File Offset: 0x0007FAB0
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

		// Token: 0x06002EEB RID: 12011 RVA: 0x000818EF File Offset: 0x0007FAEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002EEC RID: 12012 RVA: 0x000818F7 File Offset: 0x0007FAF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002EED RID: 12013 RVA: 0x00081900 File Offset: 0x0007FB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MazeBuffId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.MazeBuffId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002EEE RID: 12014 RVA: 0x00081934 File Offset: 0x0007FB34
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

		// Token: 0x06002EEF RID: 12015 RVA: 0x00081972 File Offset: 0x0007FB72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnhanceChessRogueBuffCsReq other)
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

		// Token: 0x06002EF0 RID: 12016 RVA: 0x000819A3 File Offset: 0x0007FBA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002EF1 RID: 12017 RVA: 0x000819AC File Offset: 0x0007FBAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MazeBuffId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040012CF RID: 4815
		private static readonly MessageParser<EnhanceChessRogueBuffCsReq> _parser = new MessageParser<EnhanceChessRogueBuffCsReq>(() => new EnhanceChessRogueBuffCsReq());

		// Token: 0x040012D0 RID: 4816
		private UnknownFieldSet _unknownFields;

		// Token: 0x040012D1 RID: 4817
		public const int MazeBuffIdFieldNumber = 12;

		// Token: 0x040012D2 RID: 4818
		private uint mazeBuffId_;
	}
}
