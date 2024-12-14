using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000317 RID: 791
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CommonRogueUpdateScNotify : IMessage<CommonRogueUpdateScNotify>, IMessage, IEquatable<CommonRogueUpdateScNotify>, IDeepCloneable<CommonRogueUpdateScNotify>, IBufferMessage
	{
		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06002371 RID: 9073 RVA: 0x00064B1F File Offset: 0x00062D1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CommonRogueUpdateScNotify> Parser
		{
			get
			{
				return CommonRogueUpdateScNotify._parser;
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x06002372 RID: 9074 RVA: 0x00064B26 File Offset: 0x00062D26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CommonRogueUpdateScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x06002373 RID: 9075 RVA: 0x00064B38 File Offset: 0x00062D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CommonRogueUpdateScNotify.Descriptor;
			}
		}

		// Token: 0x06002374 RID: 9076 RVA: 0x00064B3F File Offset: 0x00062D3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonRogueUpdateScNotify()
		{
		}

		// Token: 0x06002375 RID: 9077 RVA: 0x00064B48 File Offset: 0x00062D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonRogueUpdateScNotify(CommonRogueUpdateScNotify other) : this()
		{
			this.rogueAreaInfo_ = ((other.rogueAreaInfo_ != null) ? other.rogueAreaInfo_.Clone() : null);
			this.oJFJFEJMJPG_ = ((other.oJFJFEJMJPG_ != null) ? other.oJFJFEJMJPG_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002376 RID: 9078 RVA: 0x00064BA4 File Offset: 0x00062DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonRogueUpdateScNotify Clone()
		{
			return new CommonRogueUpdateScNotify(this);
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06002377 RID: 9079 RVA: 0x00064BAC File Offset: 0x00062DAC
		// (set) Token: 0x06002378 RID: 9080 RVA: 0x00064BB4 File Offset: 0x00062DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LMPOJGEHFIP RogueAreaInfo
		{
			get
			{
				return this.rogueAreaInfo_;
			}
			set
			{
				this.rogueAreaInfo_ = value;
			}
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06002379 RID: 9081 RVA: 0x00064BBD File Offset: 0x00062DBD
		// (set) Token: 0x0600237A RID: 9082 RVA: 0x00064BC5 File Offset: 0x00062DC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KIANELPLCMF OJFJFEJMJPG
		{
			get
			{
				return this.oJFJFEJMJPG_;
			}
			set
			{
				this.oJFJFEJMJPG_ = value;
			}
		}

		// Token: 0x0600237B RID: 9083 RVA: 0x00064BCE File Offset: 0x00062DCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CommonRogueUpdateScNotify);
		}

		// Token: 0x0600237C RID: 9084 RVA: 0x00064BDC File Offset: 0x00062DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CommonRogueUpdateScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.RogueAreaInfo, other.RogueAreaInfo) && object.Equals(this.OJFJFEJMJPG, other.OJFJFEJMJPG) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600237D RID: 9085 RVA: 0x00064C30 File Offset: 0x00062E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueAreaInfo_ != null)
			{
				num ^= this.RogueAreaInfo.GetHashCode();
			}
			if (this.oJFJFEJMJPG_ != null)
			{
				num ^= this.OJFJFEJMJPG.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600237E RID: 9086 RVA: 0x00064C82 File Offset: 0x00062E82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600237F RID: 9087 RVA: 0x00064C8A File Offset: 0x00062E8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002380 RID: 9088 RVA: 0x00064C94 File Offset: 0x00062E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.oJFJFEJMJPG_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.OJFJFEJMJPG);
			}
			if (this.rogueAreaInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.RogueAreaInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002381 RID: 9089 RVA: 0x00064CF0 File Offset: 0x00062EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueAreaInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueAreaInfo);
			}
			if (this.oJFJFEJMJPG_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.OJFJFEJMJPG);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002382 RID: 9090 RVA: 0x00064D48 File Offset: 0x00062F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CommonRogueUpdateScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueAreaInfo_ != null)
			{
				if (this.rogueAreaInfo_ == null)
				{
					this.RogueAreaInfo = new LMPOJGEHFIP();
				}
				this.RogueAreaInfo.MergeFrom(other.RogueAreaInfo);
			}
			if (other.oJFJFEJMJPG_ != null)
			{
				if (this.oJFJFEJMJPG_ == null)
				{
					this.OJFJFEJMJPG = new KIANELPLCMF();
				}
				this.OJFJFEJMJPG.MergeFrom(other.OJFJFEJMJPG);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002383 RID: 9091 RVA: 0x00064DC8 File Offset: 0x00062FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002384 RID: 9092 RVA: 0x00064DD4 File Offset: 0x00062FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 66U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.rogueAreaInfo_ == null)
						{
							this.RogueAreaInfo = new LMPOJGEHFIP();
						}
						input.ReadMessage(this.RogueAreaInfo);
					}
				}
				else
				{
					if (this.oJFJFEJMJPG_ == null)
					{
						this.OJFJFEJMJPG = new KIANELPLCMF();
					}
					input.ReadMessage(this.OJFJFEJMJPG);
				}
			}
		}

		// Token: 0x04000E90 RID: 3728
		private static readonly MessageParser<CommonRogueUpdateScNotify> _parser = new MessageParser<CommonRogueUpdateScNotify>(() => new CommonRogueUpdateScNotify());

		// Token: 0x04000E91 RID: 3729
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E92 RID: 3730
		public const int RogueAreaInfoFieldNumber = 14;

		// Token: 0x04000E93 RID: 3731
		private LMPOJGEHFIP rogueAreaInfo_;

		// Token: 0x04000E94 RID: 3732
		public const int OJFJFEJMJPGFieldNumber = 8;

		// Token: 0x04000E95 RID: 3733
		private KIANELPLCMF oJFJFEJMJPG_;
	}
}
