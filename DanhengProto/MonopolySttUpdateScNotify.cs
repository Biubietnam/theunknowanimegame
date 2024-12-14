using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B7D RID: 2941
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolySttUpdateScNotify : IMessage<MonopolySttUpdateScNotify>, IMessage, IEquatable<MonopolySttUpdateScNotify>, IDeepCloneable<MonopolySttUpdateScNotify>, IBufferMessage
	{
		// Token: 0x17002472 RID: 9330
		// (get) Token: 0x06008228 RID: 33320 RVA: 0x00156D7D File Offset: 0x00154F7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolySttUpdateScNotify> Parser
		{
			get
			{
				return MonopolySttUpdateScNotify._parser;
			}
		}

		// Token: 0x17002473 RID: 9331
		// (get) Token: 0x06008229 RID: 33321 RVA: 0x00156D84 File Offset: 0x00154F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolySttUpdateScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002474 RID: 9332
		// (get) Token: 0x0600822A RID: 33322 RVA: 0x00156D96 File Offset: 0x00154F96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolySttUpdateScNotify.Descriptor;
			}
		}

		// Token: 0x0600822B RID: 33323 RVA: 0x00156D9D File Offset: 0x00154F9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolySttUpdateScNotify()
		{
		}

		// Token: 0x0600822C RID: 33324 RVA: 0x00156DA5 File Offset: 0x00154FA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolySttUpdateScNotify(MonopolySttUpdateScNotify other) : this()
		{
			this.stt_ = ((other.stt_ != null) ? other.stt_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600822D RID: 33325 RVA: 0x00156DDA File Offset: 0x00154FDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolySttUpdateScNotify Clone()
		{
			return new MonopolySttUpdateScNotify(this);
		}

		// Token: 0x17002475 RID: 9333
		// (get) Token: 0x0600822E RID: 33326 RVA: 0x00156DE2 File Offset: 0x00154FE2
		// (set) Token: 0x0600822F RID: 33327 RVA: 0x00156DEA File Offset: 0x00154FEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PAPEPLFDCON Stt
		{
			get
			{
				return this.stt_;
			}
			set
			{
				this.stt_ = value;
			}
		}

		// Token: 0x06008230 RID: 33328 RVA: 0x00156DF3 File Offset: 0x00154FF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolySttUpdateScNotify);
		}

		// Token: 0x06008231 RID: 33329 RVA: 0x00156E01 File Offset: 0x00155001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolySttUpdateScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Stt, other.Stt) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008232 RID: 33330 RVA: 0x00156E34 File Offset: 0x00155034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.stt_ != null)
			{
				num ^= this.Stt.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008233 RID: 33331 RVA: 0x00156E70 File Offset: 0x00155070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008234 RID: 33332 RVA: 0x00156E78 File Offset: 0x00155078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008235 RID: 33333 RVA: 0x00156E81 File Offset: 0x00155081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.stt_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Stt);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008236 RID: 33334 RVA: 0x00156EB4 File Offset: 0x001550B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.stt_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Stt);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008237 RID: 33335 RVA: 0x00156EF4 File Offset: 0x001550F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolySttUpdateScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.stt_ != null)
			{
				if (this.stt_ == null)
				{
					this.Stt = new PAPEPLFDCON();
				}
				this.Stt.MergeFrom(other.Stt);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008238 RID: 33336 RVA: 0x00156F48 File Offset: 0x00155148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008239 RID: 33337 RVA: 0x00156F54 File Offset: 0x00155154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.stt_ == null)
					{
						this.Stt = new PAPEPLFDCON();
					}
					input.ReadMessage(this.Stt);
				}
			}
		}

		// Token: 0x040031A5 RID: 12709
		private static readonly MessageParser<MonopolySttUpdateScNotify> _parser = new MessageParser<MonopolySttUpdateScNotify>(() => new MonopolySttUpdateScNotify());

		// Token: 0x040031A6 RID: 12710
		private UnknownFieldSet _unknownFields;

		// Token: 0x040031A7 RID: 12711
		public const int SttFieldNumber = 1;

		// Token: 0x040031A8 RID: 12712
		private PAPEPLFDCON stt_;
	}
}
