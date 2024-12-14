using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200089B RID: 2203
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HealPoolInfoNotify : IMessage<HealPoolInfoNotify>, IMessage, IEquatable<HealPoolInfoNotify>, IDeepCloneable<HealPoolInfoNotify>, IBufferMessage
	{
		// Token: 0x17001BAE RID: 7086
		// (get) Token: 0x06006254 RID: 25172 RVA: 0x00107319 File Offset: 0x00105519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HealPoolInfoNotify> Parser
		{
			get
			{
				return HealPoolInfoNotify._parser;
			}
		}

		// Token: 0x17001BAF RID: 7087
		// (get) Token: 0x06006255 RID: 25173 RVA: 0x00107320 File Offset: 0x00105520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HealPoolInfoNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001BB0 RID: 7088
		// (get) Token: 0x06006256 RID: 25174 RVA: 0x00107332 File Offset: 0x00105532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HealPoolInfoNotify.Descriptor;
			}
		}

		// Token: 0x06006257 RID: 25175 RVA: 0x00107339 File Offset: 0x00105539
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HealPoolInfoNotify()
		{
		}

		// Token: 0x06006258 RID: 25176 RVA: 0x00107341 File Offset: 0x00105541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HealPoolInfoNotify(HealPoolInfoNotify other) : this()
		{
			this.healPoolInfo_ = ((other.healPoolInfo_ != null) ? other.healPoolInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006259 RID: 25177 RVA: 0x00107376 File Offset: 0x00105576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HealPoolInfoNotify Clone()
		{
			return new HealPoolInfoNotify(this);
		}

		// Token: 0x17001BB1 RID: 7089
		// (get) Token: 0x0600625A RID: 25178 RVA: 0x0010737E File Offset: 0x0010557E
		// (set) Token: 0x0600625B RID: 25179 RVA: 0x00107386 File Offset: 0x00105586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HealPoolInfo HealPoolInfo
		{
			get
			{
				return this.healPoolInfo_;
			}
			set
			{
				this.healPoolInfo_ = value;
			}
		}

		// Token: 0x0600625C RID: 25180 RVA: 0x0010738F File Offset: 0x0010558F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HealPoolInfoNotify);
		}

		// Token: 0x0600625D RID: 25181 RVA: 0x0010739D File Offset: 0x0010559D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HealPoolInfoNotify other)
		{
			return other != null && (other == this || (object.Equals(this.HealPoolInfo, other.HealPoolInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600625E RID: 25182 RVA: 0x001073D0 File Offset: 0x001055D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.healPoolInfo_ != null)
			{
				num ^= this.HealPoolInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600625F RID: 25183 RVA: 0x0010740C File Offset: 0x0010560C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006260 RID: 25184 RVA: 0x00107414 File Offset: 0x00105614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006261 RID: 25185 RVA: 0x0010741D File Offset: 0x0010561D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.healPoolInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.HealPoolInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006262 RID: 25186 RVA: 0x00107450 File Offset: 0x00105650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.healPoolInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HealPoolInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006263 RID: 25187 RVA: 0x00107490 File Offset: 0x00105690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HealPoolInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.healPoolInfo_ != null)
			{
				if (this.healPoolInfo_ == null)
				{
					this.HealPoolInfo = new HealPoolInfo();
				}
				this.HealPoolInfo.MergeFrom(other.HealPoolInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006264 RID: 25188 RVA: 0x001074E4 File Offset: 0x001056E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006265 RID: 25189 RVA: 0x001074F0 File Offset: 0x001056F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.healPoolInfo_ == null)
					{
						this.HealPoolInfo = new HealPoolInfo();
					}
					input.ReadMessage(this.HealPoolInfo);
				}
			}
		}

		// Token: 0x040025CC RID: 9676
		private static readonly MessageParser<HealPoolInfoNotify> _parser = new MessageParser<HealPoolInfoNotify>(() => new HealPoolInfoNotify());

		// Token: 0x040025CD RID: 9677
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025CE RID: 9678
		public const int HealPoolInfoFieldNumber = 12;

		// Token: 0x040025CF RID: 9679
		private HealPoolInfo healPoolInfo_;
	}
}
