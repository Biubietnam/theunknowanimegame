using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010D9 RID: 4313
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetClientPausedCsReq : IMessage<SetClientPausedCsReq>, IMessage, IEquatable<SetClientPausedCsReq>, IDeepCloneable<SetClientPausedCsReq>, IBufferMessage
	{
		// Token: 0x1700364B RID: 13899
		// (get) Token: 0x0600C052 RID: 49234 RVA: 0x00205914 File Offset: 0x00203B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetClientPausedCsReq> Parser
		{
			get
			{
				return SetClientPausedCsReq._parser;
			}
		}

		// Token: 0x1700364C RID: 13900
		// (get) Token: 0x0600C053 RID: 49235 RVA: 0x0020591B File Offset: 0x00203B1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetClientPausedCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700364D RID: 13901
		// (get) Token: 0x0600C054 RID: 49236 RVA: 0x0020592D File Offset: 0x00203B2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetClientPausedCsReq.Descriptor;
			}
		}

		// Token: 0x0600C055 RID: 49237 RVA: 0x00205934 File Offset: 0x00203B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetClientPausedCsReq()
		{
		}

		// Token: 0x0600C056 RID: 49238 RVA: 0x0020593C File Offset: 0x00203B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetClientPausedCsReq(SetClientPausedCsReq other) : this()
		{
			this.paused_ = other.paused_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C057 RID: 49239 RVA: 0x00205961 File Offset: 0x00203B61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetClientPausedCsReq Clone()
		{
			return new SetClientPausedCsReq(this);
		}

		// Token: 0x1700364E RID: 13902
		// (get) Token: 0x0600C058 RID: 49240 RVA: 0x00205969 File Offset: 0x00203B69
		// (set) Token: 0x0600C059 RID: 49241 RVA: 0x00205971 File Offset: 0x00203B71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Paused
		{
			get
			{
				return this.paused_;
			}
			set
			{
				this.paused_ = value;
			}
		}

		// Token: 0x0600C05A RID: 49242 RVA: 0x0020597A File Offset: 0x00203B7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetClientPausedCsReq);
		}

		// Token: 0x0600C05B RID: 49243 RVA: 0x00205988 File Offset: 0x00203B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetClientPausedCsReq other)
		{
			return other != null && (other == this || (this.Paused == other.Paused && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C05C RID: 49244 RVA: 0x002059B8 File Offset: 0x00203BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Paused)
			{
				num ^= this.Paused.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C05D RID: 49245 RVA: 0x002059F7 File Offset: 0x00203BF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C05E RID: 49246 RVA: 0x002059FF File Offset: 0x00203BFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C05F RID: 49247 RVA: 0x00205A08 File Offset: 0x00203C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Paused)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.Paused);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C060 RID: 49248 RVA: 0x00205A3C File Offset: 0x00203C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Paused)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C061 RID: 49249 RVA: 0x00205A6E File Offset: 0x00203C6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetClientPausedCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Paused)
			{
				this.Paused = other.Paused;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C062 RID: 49250 RVA: 0x00205A9F File Offset: 0x00203C9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C063 RID: 49251 RVA: 0x00205AA8 File Offset: 0x00203CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Paused = input.ReadBool();
				}
			}
		}

		// Token: 0x04004E01 RID: 19969
		private static readonly MessageParser<SetClientPausedCsReq> _parser = new MessageParser<SetClientPausedCsReq>(() => new SetClientPausedCsReq());

		// Token: 0x04004E02 RID: 19970
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E03 RID: 19971
		public const int PausedFieldNumber = 15;

		// Token: 0x04004E04 RID: 19972
		private bool paused_;
	}
}
