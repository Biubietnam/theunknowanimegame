using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000897 RID: 2199
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HeadIconData : IMessage<HeadIconData>, IMessage, IEquatable<HeadIconData>, IDeepCloneable<HeadIconData>, IBufferMessage
	{
		// Token: 0x17001BA3 RID: 7075
		// (get) Token: 0x06006228 RID: 25128 RVA: 0x00106D67 File Offset: 0x00104F67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HeadIconData> Parser
		{
			get
			{
				return HeadIconData._parser;
			}
		}

		// Token: 0x17001BA4 RID: 7076
		// (get) Token: 0x06006229 RID: 25129 RVA: 0x00106D6E File Offset: 0x00104F6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeadIconDataReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001BA5 RID: 7077
		// (get) Token: 0x0600622A RID: 25130 RVA: 0x00106D80 File Offset: 0x00104F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeadIconData.Descriptor;
			}
		}

		// Token: 0x0600622B RID: 25131 RVA: 0x00106D87 File Offset: 0x00104F87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeadIconData()
		{
		}

		// Token: 0x0600622C RID: 25132 RVA: 0x00106D8F File Offset: 0x00104F8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeadIconData(HeadIconData other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600622D RID: 25133 RVA: 0x00106DB4 File Offset: 0x00104FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeadIconData Clone()
		{
			return new HeadIconData(this);
		}

		// Token: 0x17001BA6 RID: 7078
		// (get) Token: 0x0600622E RID: 25134 RVA: 0x00106DBC File Offset: 0x00104FBC
		// (set) Token: 0x0600622F RID: 25135 RVA: 0x00106DC4 File Offset: 0x00104FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x06006230 RID: 25136 RVA: 0x00106DCD File Offset: 0x00104FCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeadIconData);
		}

		// Token: 0x06006231 RID: 25137 RVA: 0x00106DDB File Offset: 0x00104FDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HeadIconData other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006232 RID: 25138 RVA: 0x00106E0C File Offset: 0x0010500C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006233 RID: 25139 RVA: 0x00106E4B File Offset: 0x0010504B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006234 RID: 25140 RVA: 0x00106E53 File Offset: 0x00105053
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006235 RID: 25141 RVA: 0x00106E5C File Offset: 0x0010505C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006236 RID: 25142 RVA: 0x00106E90 File Offset: 0x00105090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006237 RID: 25143 RVA: 0x00106ECE File Offset: 0x001050CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HeadIconData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006238 RID: 25144 RVA: 0x00106EFF File Offset: 0x001050FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006239 RID: 25145 RVA: 0x00106F08 File Offset: 0x00105108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040025C0 RID: 9664
		private static readonly MessageParser<HeadIconData> _parser = new MessageParser<HeadIconData>(() => new HeadIconData());

		// Token: 0x040025C1 RID: 9665
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025C2 RID: 9666
		public const int IdFieldNumber = 5;

		// Token: 0x040025C3 RID: 9667
		private uint id_;
	}
}
