using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C2D RID: 3117
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NpcDialogueEventParam : IMessage<NpcDialogueEventParam>, IMessage, IEquatable<NpcDialogueEventParam>, IDeepCloneable<NpcDialogueEventParam>, IBufferMessage
	{
		// Token: 0x170026C2 RID: 9922
		// (get) Token: 0x06008A1D RID: 35357 RVA: 0x0016CB6D File Offset: 0x0016AD6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NpcDialogueEventParam> Parser
		{
			get
			{
				return NpcDialogueEventParam._parser;
			}
		}

		// Token: 0x170026C3 RID: 9923
		// (get) Token: 0x06008A1E RID: 35358 RVA: 0x0016CB74 File Offset: 0x0016AD74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NpcDialogueEventParamReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170026C4 RID: 9924
		// (get) Token: 0x06008A1F RID: 35359 RVA: 0x0016CB86 File Offset: 0x0016AD86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcDialogueEventParam.Descriptor;
			}
		}

		// Token: 0x06008A20 RID: 35360 RVA: 0x0016CB8D File Offset: 0x0016AD8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcDialogueEventParam()
		{
		}

		// Token: 0x06008A21 RID: 35361 RVA: 0x0016CB95 File Offset: 0x0016AD95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcDialogueEventParam(NpcDialogueEventParam other) : this()
		{
			this.rogueDialogueEventId_ = other.rogueDialogueEventId_;
			this.argId_ = other.argId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008A22 RID: 35362 RVA: 0x0016CBC6 File Offset: 0x0016ADC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcDialogueEventParam Clone()
		{
			return new NpcDialogueEventParam(this);
		}

		// Token: 0x170026C5 RID: 9925
		// (get) Token: 0x06008A23 RID: 35363 RVA: 0x0016CBCE File Offset: 0x0016ADCE
		// (set) Token: 0x06008A24 RID: 35364 RVA: 0x0016CBD6 File Offset: 0x0016ADD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RogueDialogueEventId
		{
			get
			{
				return this.rogueDialogueEventId_;
			}
			set
			{
				this.rogueDialogueEventId_ = value;
			}
		}

		// Token: 0x170026C6 RID: 9926
		// (get) Token: 0x06008A25 RID: 35365 RVA: 0x0016CBDF File Offset: 0x0016ADDF
		// (set) Token: 0x06008A26 RID: 35366 RVA: 0x0016CBE7 File Offset: 0x0016ADE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ArgId
		{
			get
			{
				return this.argId_;
			}
			set
			{
				this.argId_ = value;
			}
		}

		// Token: 0x06008A27 RID: 35367 RVA: 0x0016CBF0 File Offset: 0x0016ADF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcDialogueEventParam);
		}

		// Token: 0x06008A28 RID: 35368 RVA: 0x0016CBFE File Offset: 0x0016ADFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcDialogueEventParam other)
		{
			return other != null && (other == this || (this.RogueDialogueEventId == other.RogueDialogueEventId && this.ArgId == other.ArgId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008A29 RID: 35369 RVA: 0x0016CC3C File Offset: 0x0016AE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RogueDialogueEventId != 0U)
			{
				num ^= this.RogueDialogueEventId.GetHashCode();
			}
			if (this.ArgId != 0U)
			{
				num ^= this.ArgId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008A2A RID: 35370 RVA: 0x0016CC94 File Offset: 0x0016AE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008A2B RID: 35371 RVA: 0x0016CC9C File Offset: 0x0016AE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008A2C RID: 35372 RVA: 0x0016CCA8 File Offset: 0x0016AEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ArgId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.ArgId);
			}
			if (this.RogueDialogueEventId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.RogueDialogueEventId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008A2D RID: 35373 RVA: 0x0016CD04 File Offset: 0x0016AF04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RogueDialogueEventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RogueDialogueEventId);
			}
			if (this.ArgId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ArgId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008A2E RID: 35374 RVA: 0x0016CD5C File Offset: 0x0016AF5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcDialogueEventParam other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RogueDialogueEventId != 0U)
			{
				this.RogueDialogueEventId = other.RogueDialogueEventId;
			}
			if (other.ArgId != 0U)
			{
				this.ArgId = other.ArgId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008A2F RID: 35375 RVA: 0x0016CDAC File Offset: 0x0016AFAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008A30 RID: 35376 RVA: 0x0016CDB8 File Offset: 0x0016AFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RogueDialogueEventId = input.ReadUInt32();
					}
				}
				else
				{
					this.ArgId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040034F9 RID: 13561
		private static readonly MessageParser<NpcDialogueEventParam> _parser = new MessageParser<NpcDialogueEventParam>(() => new NpcDialogueEventParam());

		// Token: 0x040034FA RID: 13562
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034FB RID: 13563
		public const int RogueDialogueEventIdFieldNumber = 9;

		// Token: 0x040034FC RID: 13564
		private uint rogueDialogueEventId_;

		// Token: 0x040034FD RID: 13565
		public const int ArgIdFieldNumber = 2;

		// Token: 0x040034FE RID: 13566
		private uint argId_;
	}
}
