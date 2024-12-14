using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A73 RID: 2675
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MainMission : IMessage<MainMission>, IMessage, IEquatable<MainMission>, IDeepCloneable<MainMission>, IBufferMessage
	{
		// Token: 0x1700214B RID: 8523
		// (get) Token: 0x06007688 RID: 30344 RVA: 0x0013A8AF File Offset: 0x00138AAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MainMission> Parser
		{
			get
			{
				return MainMission._parser;
			}
		}

		// Token: 0x1700214C RID: 8524
		// (get) Token: 0x06007689 RID: 30345 RVA: 0x0013A8B6 File Offset: 0x00138AB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MainMissionReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700214D RID: 8525
		// (get) Token: 0x0600768A RID: 30346 RVA: 0x0013A8C8 File Offset: 0x00138AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MainMission.Descriptor;
			}
		}

		// Token: 0x0600768B RID: 30347 RVA: 0x0013A8CF File Offset: 0x00138ACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MainMission()
		{
		}

		// Token: 0x0600768C RID: 30348 RVA: 0x0013A8E4 File Offset: 0x00138AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MainMission(MainMission other) : this()
		{
			this.id_ = other.id_;
			this.customValueList_ = other.customValueList_.Clone();
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600768D RID: 30349 RVA: 0x0013A931 File Offset: 0x00138B31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MainMission Clone()
		{
			return new MainMission(this);
		}

		// Token: 0x1700214E RID: 8526
		// (get) Token: 0x0600768E RID: 30350 RVA: 0x0013A939 File Offset: 0x00138B39
		// (set) Token: 0x0600768F RID: 30351 RVA: 0x0013A941 File Offset: 0x00138B41
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

		// Token: 0x1700214F RID: 8527
		// (get) Token: 0x06007690 RID: 30352 RVA: 0x0013A94A File Offset: 0x00138B4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MissionCustomValue> CustomValueList
		{
			get
			{
				return this.customValueList_;
			}
		}

		// Token: 0x17002150 RID: 8528
		// (get) Token: 0x06007691 RID: 30353 RVA: 0x0013A952 File Offset: 0x00138B52
		// (set) Token: 0x06007692 RID: 30354 RVA: 0x0013A95A File Offset: 0x00138B5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MissionStatus Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x06007693 RID: 30355 RVA: 0x0013A963 File Offset: 0x00138B63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MainMission);
		}

		// Token: 0x06007694 RID: 30356 RVA: 0x0013A974 File Offset: 0x00138B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MainMission other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.customValueList_.Equals(other.customValueList_) && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007695 RID: 30357 RVA: 0x0013A9D4 File Offset: 0x00138BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.customValueList_.GetHashCode();
			if (this.Status != MissionStatus.MissionNone)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007696 RID: 30358 RVA: 0x0013AA40 File Offset: 0x00138C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007697 RID: 30359 RVA: 0x0013AA48 File Offset: 0x00138C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007698 RID: 30360 RVA: 0x0013AA54 File Offset: 0x00138C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.customValueList_.WriteTo(ref output, MainMission._repeated_customValueList_codec);
			if (this.Id != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Id);
			}
			if (this.Status != MissionStatus.MissionNone)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007699 RID: 30361 RVA: 0x0013AAC0 File Offset: 0x00138CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			num += this.customValueList_.CalculateSize(MainMission._repeated_customValueList_codec);
			if (this.Status != MissionStatus.MissionNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600769A RID: 30362 RVA: 0x0013AB2C File Offset: 0x00138D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MainMission other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			this.customValueList_.Add(other.customValueList_);
			if (other.Status != MissionStatus.MissionNone)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600769B RID: 30363 RVA: 0x0013AB8D File Offset: 0x00138D8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600769C RID: 30364 RVA: 0x0013AB98 File Offset: 0x00138D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 112U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Status = (MissionStatus)input.ReadEnum();
						}
					}
					else
					{
						this.Id = input.ReadUInt32();
					}
				}
				else
				{
					this.customValueList_.AddEntriesFrom(ref input, MainMission._repeated_customValueList_codec);
				}
			}
		}

		// Token: 0x04002D8E RID: 11662
		private static readonly MessageParser<MainMission> _parser = new MessageParser<MainMission>(() => new MainMission());

		// Token: 0x04002D8F RID: 11663
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D90 RID: 11664
		public const int IdFieldNumber = 14;

		// Token: 0x04002D91 RID: 11665
		private uint id_;

		// Token: 0x04002D92 RID: 11666
		public const int CustomValueListFieldNumber = 1;

		// Token: 0x04002D93 RID: 11667
		private static readonly FieldCodec<MissionCustomValue> _repeated_customValueList_codec = FieldCodec.ForMessage<MissionCustomValue>(10U, MissionCustomValue.Parser);

		// Token: 0x04002D94 RID: 11668
		private readonly RepeatedField<MissionCustomValue> customValueList_ = new RepeatedField<MissionCustomValue>();

		// Token: 0x04002D95 RID: 11669
		public const int StatusFieldNumber = 15;

		// Token: 0x04002D96 RID: 11670
		private MissionStatus status_;
	}
}
