using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002E9 RID: 745
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ClockParkFinishScriptScNotify : IMessage<ClockParkFinishScriptScNotify>, IMessage, IEquatable<ClockParkFinishScriptScNotify>, IDeepCloneable<ClockParkFinishScriptScNotify>, IBufferMessage
	{
		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x0600213D RID: 8509 RVA: 0x0005E665 File Offset: 0x0005C865
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ClockParkFinishScriptScNotify> Parser
		{
			get
			{
				return ClockParkFinishScriptScNotify._parser;
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x0600213E RID: 8510 RVA: 0x0005E66C File Offset: 0x0005C86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClockParkFinishScriptScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x0600213F RID: 8511 RVA: 0x0005E67E File Offset: 0x0005C87E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClockParkFinishScriptScNotify.Descriptor;
			}
		}

		// Token: 0x06002140 RID: 8512 RVA: 0x0005E685 File Offset: 0x0005C885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkFinishScriptScNotify()
		{
		}

		// Token: 0x06002141 RID: 8513 RVA: 0x0005E68D File Offset: 0x0005C88D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkFinishScriptScNotify(ClockParkFinishScriptScNotify other) : this()
		{
			this.rogueFinishInfo_ = ((other.rogueFinishInfo_ != null) ? other.rogueFinishInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002142 RID: 8514 RVA: 0x0005E6C2 File Offset: 0x0005C8C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkFinishScriptScNotify Clone()
		{
			return new ClockParkFinishScriptScNotify(this);
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06002143 RID: 8515 RVA: 0x0005E6CA File Offset: 0x0005C8CA
		// (set) Token: 0x06002144 RID: 8516 RVA: 0x0005E6D2 File Offset: 0x0005C8D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BHCFGECDIDJ RogueFinishInfo
		{
			get
			{
				return this.rogueFinishInfo_;
			}
			set
			{
				this.rogueFinishInfo_ = value;
			}
		}

		// Token: 0x06002145 RID: 8517 RVA: 0x0005E6DB File Offset: 0x0005C8DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClockParkFinishScriptScNotify);
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x0005E6E9 File Offset: 0x0005C8E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClockParkFinishScriptScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.RogueFinishInfo, other.RogueFinishInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x0005E71C File Offset: 0x0005C91C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueFinishInfo_ != null)
			{
				num ^= this.RogueFinishInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x0005E758 File Offset: 0x0005C958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002149 RID: 8521 RVA: 0x0005E760 File Offset: 0x0005C960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600214A RID: 8522 RVA: 0x0005E769 File Offset: 0x0005C969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueFinishInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.RogueFinishInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x0005E79C File Offset: 0x0005C99C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueFinishInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueFinishInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600214C RID: 8524 RVA: 0x0005E7DC File Offset: 0x0005C9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClockParkFinishScriptScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueFinishInfo_ != null)
			{
				if (this.rogueFinishInfo_ == null)
				{
					this.RogueFinishInfo = new BHCFGECDIDJ();
				}
				this.RogueFinishInfo.MergeFrom(other.RogueFinishInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600214D RID: 8525 RVA: 0x0005E830 File Offset: 0x0005CA30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600214E RID: 8526 RVA: 0x0005E83C File Offset: 0x0005CA3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.rogueFinishInfo_ == null)
					{
						this.RogueFinishInfo = new BHCFGECDIDJ();
					}
					input.ReadMessage(this.RogueFinishInfo);
				}
			}
		}

		// Token: 0x04000DB0 RID: 3504
		private static readonly MessageParser<ClockParkFinishScriptScNotify> _parser = new MessageParser<ClockParkFinishScriptScNotify>(() => new ClockParkFinishScriptScNotify());

		// Token: 0x04000DB1 RID: 3505
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000DB2 RID: 3506
		public const int RogueFinishInfoFieldNumber = 5;

		// Token: 0x04000DB3 RID: 3507
		private BHCFGECDIDJ rogueFinishInfo_;
	}
}
