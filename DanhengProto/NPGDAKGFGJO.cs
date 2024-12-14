using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C3F RID: 3135
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NPGDAKGFGJO : IMessage<NPGDAKGFGJO>, IMessage, IEquatable<NPGDAKGFGJO>, IDeepCloneable<NPGDAKGFGJO>, IBufferMessage
	{
		// Token: 0x17002708 RID: 9992
		// (get) Token: 0x06008B07 RID: 35591 RVA: 0x0016F591 File Offset: 0x0016D791
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NPGDAKGFGJO> Parser
		{
			get
			{
				return NPGDAKGFGJO._parser;
			}
		}

		// Token: 0x17002709 RID: 9993
		// (get) Token: 0x06008B08 RID: 35592 RVA: 0x0016F598 File Offset: 0x0016D798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NPGDAKGFGJOReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700270A RID: 9994
		// (get) Token: 0x06008B09 RID: 35593 RVA: 0x0016F5AA File Offset: 0x0016D7AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NPGDAKGFGJO.Descriptor;
			}
		}

		// Token: 0x06008B0A RID: 35594 RVA: 0x0016F5B1 File Offset: 0x0016D7B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NPGDAKGFGJO()
		{
		}

		// Token: 0x06008B0B RID: 35595 RVA: 0x0016F5B9 File Offset: 0x0016D7B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NPGDAKGFGJO(NPGDAKGFGJO other) : this()
		{
			this.miracleInfo_ = ((other.miracleInfo_ != null) ? other.miracleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008B0C RID: 35596 RVA: 0x0016F5EE File Offset: 0x0016D7EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NPGDAKGFGJO Clone()
		{
			return new NPGDAKGFGJO(this);
		}

		// Token: 0x1700270B RID: 9995
		// (get) Token: 0x06008B0D RID: 35597 RVA: 0x0016F5F6 File Offset: 0x0016D7F6
		// (set) Token: 0x06008B0E RID: 35598 RVA: 0x0016F5FE File Offset: 0x0016D7FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameRogueMiracle MiracleInfo
		{
			get
			{
				return this.miracleInfo_;
			}
			set
			{
				this.miracleInfo_ = value;
			}
		}

		// Token: 0x06008B0F RID: 35599 RVA: 0x0016F607 File Offset: 0x0016D807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NPGDAKGFGJO);
		}

		// Token: 0x06008B10 RID: 35600 RVA: 0x0016F615 File Offset: 0x0016D815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NPGDAKGFGJO other)
		{
			return other != null && (other == this || (object.Equals(this.MiracleInfo, other.MiracleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008B11 RID: 35601 RVA: 0x0016F648 File Offset: 0x0016D848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.miracleInfo_ != null)
			{
				num ^= this.MiracleInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008B12 RID: 35602 RVA: 0x0016F684 File Offset: 0x0016D884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008B13 RID: 35603 RVA: 0x0016F68C File Offset: 0x0016D88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008B14 RID: 35604 RVA: 0x0016F695 File Offset: 0x0016D895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.miracleInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.MiracleInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008B15 RID: 35605 RVA: 0x0016F6C8 File Offset: 0x0016D8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.miracleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MiracleInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008B16 RID: 35606 RVA: 0x0016F708 File Offset: 0x0016D908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NPGDAKGFGJO other)
		{
			if (other == null)
			{
				return;
			}
			if (other.miracleInfo_ != null)
			{
				if (this.miracleInfo_ == null)
				{
					this.MiracleInfo = new GameRogueMiracle();
				}
				this.MiracleInfo.MergeFrom(other.MiracleInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008B17 RID: 35607 RVA: 0x0016F75C File Offset: 0x0016D95C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008B18 RID: 35608 RVA: 0x0016F768 File Offset: 0x0016D968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.miracleInfo_ == null)
					{
						this.MiracleInfo = new GameRogueMiracle();
					}
					input.ReadMessage(this.MiracleInfo);
				}
			}
		}

		// Token: 0x0400355D RID: 13661
		private static readonly MessageParser<NPGDAKGFGJO> _parser = new MessageParser<NPGDAKGFGJO>(() => new NPGDAKGFGJO());

		// Token: 0x0400355E RID: 13662
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400355F RID: 13663
		public const int MiracleInfoFieldNumber = 4;

		// Token: 0x04003560 RID: 13664
		private GameRogueMiracle miracleInfo_;
	}
}
